using System;
using System.Collections.Generic;
using HarmonyLib;
using Raikoneer.Locations;

namespace RaikoneerVersions.Locations
{
    [HarmonyPatch(typeof(ZNet), nameof(ZNet.OnNewConnection))]
    public static class RegisterAndCheckVersion
    {
        private static void Prefix(ZNetPeer peer, ref ZNet __instance)
        {
            // Register version check call

            Raikoneer.Locations.RaikoneerLocations.PluginLogger.LogDebug("Registering version RPC handler");
            peer.m_rpc.Register($"{Raikoneer.Locations.RaikoneerLocations.ModName}_VersionCheck",
                new Action<ZRpc, ZPackage>(RpcHandlers.RaikoneerLocationsRPC));

            // Make calls to check versions
            Raikoneer.Locations.RaikoneerLocations.PluginLogger.LogDebug("Invoking version check");
            ZPackage zpackage = new();
            zpackage.Write(Raikoneer.Locations.RaikoneerLocations.ModVersion);
            peer.m_rpc.Invoke($"{Raikoneer.Locations.RaikoneerLocations.ModName}_VersionCheck", zpackage);
        }
    }

    [HarmonyPatch(typeof(ZNet), nameof(ZNet.RPC_PeerInfo))]
    public static class VerifyClient
    {
        private static bool Prefix(ZRpc rpc, ZPackage pkg, ref ZNet __instance)
        {
            if (!__instance.IsServer() || RpcHandlers.ValidatedPeers.Contains(rpc)) return true;
            // Disconnect peer if they didn't send mod version at all
            Raikoneer.Locations.RaikoneerLocations.PluginLogger.LogWarning(
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
                __instance.m_connectionFailedError.text += "\n" + Raikoneer.Locations.RaikoneerLocations.ConnectionError;
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
            Raikoneer.Locations.RaikoneerLocations.PluginLogger.LogInfo(
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
            Raikoneer.Locations.RaikoneerLocations.PluginLogger.LogInfo("Version check, local: " +
                                                                                      Raikoneer.Locations.RaikoneerLocations.ModVersion +
                                                                                      ",  remote: " + version);
            if (version != Raikoneer.Locations.RaikoneerLocations.ModVersion)
            {
                Raikoneer.Locations.RaikoneerLocations.ConnectionError = $"{Raikoneer.Locations.RaikoneerLocations.ModName} Installed: {Raikoneer.Locations.RaikoneerLocations.ModVersion}\n Needed: {version}";
                if (!ZNet.instance.IsServer()) return;
                // Different versions - force disconnect client from server
                Raikoneer.Locations.RaikoneerLocations.PluginLogger.LogWarning($"Peer ({rpc.m_socket.GetHostName()}) has incompatible version, disconnecting...");
                rpc.Invoke("Error", 3);
            }
            else
            {
                if (!ZNet.instance.IsServer())
                {
                    // Enable mod on client if versions match
                    Raikoneer.Locations.RaikoneerLocations.PluginLogger.LogInfo("Received same version from server!");
                }
                else
                {
                    // Add client to validated list
                    Raikoneer.Locations.RaikoneerLocations.PluginLogger.LogInfo(
                        $"Adding peer ({rpc.m_socket.GetHostName()}) to validated list");
                    ValidatedPeers.Add(rpc);
                }
            }
        }
    }
}