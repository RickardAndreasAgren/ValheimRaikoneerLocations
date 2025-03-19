#nullable enable

extern alias ServerSyncStandalone;

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using Raikoneer.Locations.PrefabIniters;
using Raikoneer.Locations.Spawners;
using ServerSyncStandalone::ServerSync;
using UnityEngine;
// using static RaikoneerLocations.PluginConfig;
using Paths = BepInEx.Paths;

namespace Raikoneer.Locations
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    [BepInDependency(DependencyModGUID, BepInDependency.DependencyFlags.HardDependency)]
    public class RaikoneerLocations : BaseUnityPlugin
    {
        internal const string ModName = "RaikoneerLocations";
        internal const string ModNameGUID = "raikoneerlocations";
        internal const string ModVersion = "0.0.8";
        internal const string Author = "Rickie26k";
        internal const string AuthorGUID = "rickie26k";
        private const string ModGUID = AuthorGUID + ".valheim." + ModNameGUID;

        private const string DependencyModGUID = "rickie26k.valheim.raikoneerlocalizations";
        internal static string ConnectionError = "RL: Failed to connect during application of plugin patches";
        public static string ConfigFileName = ModName + ".cfg";
        public static string ConfigFileFullPath = Paths.ConfigPath + Path.DirectorySeparatorChar + ConfigFileName;
        public static bool fixedReferences;
        public static Harmony? HarmonyInstance { get; private set; } = null;

        public static readonly ManualLogSource PluginLogger =
            BepInEx.Logging.Logger.CreateLogSource(ModName);

        public static readonly ConfigSync Sync = new(ModGUID)
        { DisplayName = ModName, CurrentVersion = ModVersion, MinimumRequiredVersion = ModVersion };

        private static ConfigEntry<Toggle> _serverConfigLocked = null!;

        public static ConfigFile? PluginConfigfile;

        private static Assembly? _pluginAssembly { get; set; } = null;
        public static AssetBundle? EmbeddedResourceBundle { get; set; } = null;
        public void Awake()
        {
            Config.Reload();
            PluginConfigfile = Config;

            (_, _serverConfigLocked) = new ConfigData<Toggle>("1 - General", "Lock Configuration", true)
                .Describe("If on, the configuration is locked and can be changed by server admins only.")
                .Bind(Config, Toggle.On);
            _ = Sync.AddLockingConfigEntry(_serverConfigLocked);
            PluginConfig.BindConfig(PluginConfigfile);

            _pluginAssembly = Assembly.GetExecutingAssembly();
            HarmonyInstance = Harmony.CreateAndPatchAll(_pluginAssembly, harmonyInstanceId: ModGUID);
            //LocalizationManager.Load();
            EmbeddedResourceBundle = LoadAssetBundle("raikoneerlocations");
            SpawnDefinitions.BuildMapDefault();
            ProcessAssets.RunPrefabs();
            ProcessAssets.RunPieces();
            ProcessAssets.RunLocations();

            SetupWatcher();
        }

        private void OnDestroy()
        {
            Config.Save();
            HarmonyInstance!.UnpatchSelf();
        }
        public enum Toggle
        {
            On = 1,
            Off = 0
        }

        private void SetupWatcher()
        {
            if (!File.Exists(RaikoneerLocations.ConfigFileFullPath)) return;
            FileSystemWatcher watcher = new(Paths.ConfigPath, ConfigFileName);
            watcher.Changed += ReadConfigValues;
            watcher.Created += ReadConfigValues;
            watcher.Renamed += ReadConfigValues;
            watcher.IncludeSubdirectories = true;
            watcher.SynchronizingObject = ThreadingHelper.SynchronizingObject;
            watcher.EnableRaisingEvents = true;
        }

        private void ReadConfigValues(object sender, FileSystemEventArgs e)
        {
            if (!File.Exists(ConfigFileFullPath)) return;
            try
            {
                PluginLogger.LogDebug("ReadConfigValues called");
                Config.Reload();
            }
            catch
            {
                PluginLogger.LogError($"There was an issue loading your {ConfigFileName}");
                PluginLogger.LogError("Please check your config entries for spelling and format!");
            }
        }

        private AssetBundle? LoadAssetBundle(string bundleName)
        {

            string text = null;
            try
            {
                text = _pluginAssembly.GetManifestResourceNames().Single((string str) => str.EndsWith(bundleName));
            }
            catch (Exception)
            {
            }

            if (text == null)
            {
                PluginLogger.LogError("AssetBundle " + bundleName + " not found in assembly manifest");
                return null;
            }

            using Stream stream = _pluginAssembly.GetManifestResourceStream(text);
            return AssetBundle.LoadFromStream(stream);
        }

        [HarmonyPatch(typeof(ZNetScene), "Awake")]
        public static class ZNetScene_Awake_Patch_LocationSpawners
        {
            public static void Postfix(ZNetScene __instance)
            {
                ProcessAssets.UpdateLocationSpawners(__instance);
                ProcessAssets.FixBoxWood();
            }
        }
    }

    public static class KeyboardExtensions
    {
        public static bool IsKeyDown(this KeyboardShortcut shortcut)
        {
            return shortcut.MainKey != KeyCode.None && Input.GetKeyDown(shortcut.MainKey) && shortcut.Modifiers.All(Input.GetKey);
        }

        public static bool IsKeyHeld(this KeyboardShortcut shortcut)
        {
            return shortcut.MainKey != KeyCode.None && Input.GetKey(shortcut.MainKey) && shortcut.Modifiers.All(Input.GetKey);
        }
    }
}