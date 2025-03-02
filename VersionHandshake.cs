using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using HarmonyLib;

namespace RaikoneerLocations
{
    [HarmonyPatch(typeof(ZNet), nameof(ZNet.OnNewConnection))]
    public static class RegisterAndCheckVersion
    {
        private static void Prefix(ZNetPeer peer, ref ZNet __instance)
        {
            // Register version check call
            RaikoneerLocations.PluginLogger.LogDebug("Registering version RPC handler");
            peer.m_rpc.Register($"{RaikoneerLocations.ModName}_VersionCheck",
                new Action<ZRpc, ZPackage>(RpcHandlers.RaikoneerLocationsRPC));

            // Make calls to check versions
            RaikoneerLocations.PluginLogger.LogDebug("Invoking version check");
            ZPackage zpackage = new();
            zpackage.Write(RaikoneerLocations.ModVersion);
            peer.m_rpc.Invoke($"{RaikoneerLocations.ModName}_VersionCheck", zpackage);
        }
    }

    [HarmonyPatch(typeof(ZNet), nameof(ZNet.RPC_PeerInfo))]
    public static class VerifyClient
    {
        private static bool Prefix(ZRpc rpc, ZPackage pkg, ref ZNet __instance)
        {
            if (!__instance.IsServer() || RpcHandlers.ValidatedPeers.Contains(rpc)) return true;
            // Disconnect peer if they didn't send mod version at all
            RaikoneerLocations.PluginLogger.LogWarning(
                $"Peer ({rpc.m_socket.GetHostName()}) never sent version or couldn't due to previous disconnect, disconnecting");
            rpc.Invoke("Error", 3);
            return false; // Prevent calling undeRaikoneerLocationsying method
        }

        private static void Postfix(ZNet __instance)
        {
            ZRoutedRpc.instance.InvokeRoutedRPC(ZRoutedRpc.instance.GetServerPeerID(), "RequestAdminSync",
                new ZPackage());
        }
    }

    [HarmonyPatch(typeof(FejdStartup), nameof(FejdStartup.ShowConnectError))]
    public class ShowConnectionError
    {
        private static void Postfix(FejdStartup __instance)
        {
            if (__instance.m_connectionFailedPanel.activeSelf)
            {
                __instance.m_connectionFailedError.fontSizeMax = 25;
                __instance.m_connectionFailedError.fontSizeMin = 15;
                __instance.m_connectionFailedError.text += "\n" + RaikoneerLocations.ConnectionError;
            }
        }
    }

    [HarmonyPatch(typeof(ZNet), nameof(ZNet.Disconnect))]
    public static class RemoveDisconnectedPeerFromVerified
    {
        private static void Prefix(ZNetPeer peer, ref ZNet __instance)
        {
            if (!__instance.IsServer()) return;
            // Remove peer from validated list
            RaikoneerLocations.PluginLogger.LogInfo(
                $"Peer ({peer.m_rpc.m_socket.GetHostName()}) disconnected, removing from validated list");
            _ = RpcHandlers.ValidatedPeers.Remove(peer.m_rpc);
        }
    }

    public static class RpcHandlers
    {
        public static readonly List<ZRpc> ValidatedPeers = new();

        public static void RaikoneerLocationsRPC(ZRpc rpc, ZPackage pkg)
        {
            string? version = pkg.ReadString();
            RaikoneerLocations.PluginLogger.LogInfo("Version check, local: " +
                                                                                      RaikoneerLocations.ModVersion +
                                                                                      ",  remote: " + version);
            if (version != RaikoneerLocations.ModVersion)
            {
                RaikoneerLocations.ConnectionError = $"{RaikoneerLocations.ModName} Installed: {RaikoneerLocations.ModVersion}\n Needed: {version}";
                if (!ZNet.instance.IsServer()) return;
                // Different versions - force disconnect client from server
                RaikoneerLocations.PluginLogger.LogWarning($"Peer ({rpc.m_socket.GetHostName()}) has incompatible version, disconnecting...");
                rpc.Invoke("Error", 3);
            }
            else
            {
                if (!ZNet.instance.IsServer())
                {
                    // Enable mod on client if versions match
                    RaikoneerLocations.PluginLogger.LogInfo("Received same version from server!");
                }
                else
                {
                    // Add client to validated list
                    RaikoneerLocations.PluginLogger.LogInfo(
                        $"Adding peer ({rpc.m_socket.GetHostName()}) to validated list");
                    ValidatedPeers.Add(rpc);
                }
            }
        }
    }
}