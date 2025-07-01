extern alias ServerSyncStandalone;

using BepInEx.Configuration;
using Raikoneer.Locations.Spawners;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

namespace Raikoneer.Locations
{
    public static class PluginConfig
    {
        public static void BindConfig(ConfigFile config)
        {
            LootChestsNotBuildable(config);
            SpawnDefinitions.BuildMapDefault();
            PluginConfig.SetupEntries(config);
        }
        public static Dictionary<string, Dictionary<string, CreatureSpawnerNameConfig>> SpawnerMap = new();
        public static Dictionary<string, Location> LocationPrefabs = new();
        public readonly static List<string> LocationSections = new();
        public static ConfigDefinition? DefLootChests { get; internal set; }
        public static ConfigEntry<int>? LootChests { get; internal set; }
        public static ConfigDefinition? DefOrangeTree { get; internal set; }
        public static ConfigEntry<bool>? OrangeTree { get; internal set; }

        public static void EnsureLocationSection(string locationName)
        {
            if (LocationSections.Contains(locationName)) return;
            LocationSections.Add(locationName);
        }
        public static void LootChestsNotBuildable(ConfigFile config)
        {
            (DefLootChests, LootChests) = new ConfigData<int>("1 - Something", "Loot chest recipes on", true)
            .Describe("Set to false, because they should not be buildable. \r\n" +
                "(0): Disable building chest pieces.\r\n" +
                "1: Enable building chest pieces.\r\n", new AcceptableValueList<int>(0,1), "RaikoneerLocations", "Location")
            .Bind(config, 0);
        }

        public static void Example(ConfigFile config)
        {
            (DefOrangeTree, OrangeTree) = new ConfigData<bool>("1 - Something", "OrangeTree", true)
            .Describe("If WildBosses is set to 1, this can be used. Allows specific disablers. \r\n" +
                "false: Disable XZ.\r\n" +
                "(true): Enable XZ.\r\n", null, "RaikoneerLocations", "Location")
            .Bind(config, true);
        }

        public static void Mobs(ConfigFile config)
        {
            // (DefSkeletonNoArcher, SkeletonNoArcher) = MobConfig("SkeletonNoArcher", config);
        }

        internal static void SetupEntries(ConfigFile config)
        {
            foreach (var location in SpawnerMap.Keys)
            {
                foreach(var entry in SpawnerMap[location])
                {
                    entry.Value.ConfigEntry(config);
                }
            }
        }

        /*
        public static (ConfigDefinition, ConfigEntry<bool>) MobConfig(string name, ConfigFile config, bool defaultEnabled = true)
        {
            return new ConfigData<bool>("3 - Monsters", $"{name}", true)
            .Describe("Toggle individual monsters. \r\n" +
                $"{(defaultEnabled ? "false" : "(false)")}: Disable {name}.\r\n" +
                $"{(defaultEnabled ? "(true)" : "true")}: Enable {name}.\r\n", null, "RaikoneerLocations", "Monster", "Creature")
            .Bind(config, defaultEnabled);
        }*/
    }

    public class CreatureSpawnerNameConfig
    {
        public CreatureSpawnerNameConfig() { }
        public CreatureSpawnerNameConfig(string defaultName, string location, string spawnerName) {
            Name = defaultName;
            SpawnerName = spawnerName;
            LocationName = location;
        }
        public string Name { get; private set; }
        public string SpawnerName { get; private set; }
        public string LocationName { get; private set; }
        private string PrefabName { get; set; }
        ConfigDefinition Definition { get; set; }
        ConfigEntry<string> Entry { get; set; }
        public ConfigEntry<string>? ConfigEntry(ConfigFile Config)
        {
            PluginConfig.EnsureLocationSection(LocationName);
            (Definition, Entry) =  new ConfigData<string>($"4.{PluginConfig.LocationSections.IndexOf(LocationName).ToString()} - Local spawners", SpawnerName, true)
                .Describe($"Set {SpawnerName} in location {LocationName}. Default: {Name} \r\n"
                    ,null
                    ,"RaikoneerLocations", "Location")
                .Bind(Config, Name);
            Name = Config[Definition].BoxedValue.ToString();
            RaikoneerLocations.PluginLogger.LogDebug($"Set up config for {Name}, and entry is {Entry.BoxedValue.ToString()}");
            Entry.SettingChanged += this.SettingsChanged;
            return Entry;
        }

        private void SettingsChanged(object sender, EventArgs e)
        {
            this.Name = RaikoneerLocations.PluginConfigfile[Definition].BoxedValue.ToString();
            TestConfigValue();
        }

        public string TestConfigValue()
        {
            if(ValidateName(out string prefabName))
            {
                PrefabName = prefabName; 
            } else
            {
                Entry.Value = Entry.DefaultValue.ToString();
                PrefabName = Entry.Value;
                RaikoneerLocations.PluginLogger.LogWarning($"Failed to validate config entry using name of {Name}");
            }
            
            return PrefabName;
        }

        private bool ValidateName(out string prefabName)
        {
            prefabName = string.Empty;

            string test = Localization.instance.Translate(Name).ToLower();
            GameObject? prefab = ZNetScene.instance.GetPrefab(test);
            if (prefab == null) prefab = ZNetScene.instance.GetPrefab(Name);

            if (prefab == null) return false;
            prefabName = prefab.name;
            return true;
        }
    }
}