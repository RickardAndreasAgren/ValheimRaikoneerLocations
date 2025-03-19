extern alias ServerSyncStandalone;

using BepInEx.Configuration;
using static UnityEngine.EventSystems.EventTrigger;

namespace Raikoneer.Locations
{
    public static class PluginConfig
    {
        public static void BindConfig(ConfigFile config)
        {
            LootChestsNotBuildable(config);
        }
        public static ConfigDefinition? DefLootChests { get; internal set; }
        public static ConfigEntry<bool>? LootChests { get; internal set; }
        public static ConfigDefinition? DefOrangeTree { get; internal set; }
        public static ConfigEntry<bool>? OrangeTree { get; internal set; }
        public static ConfigDefinition? DefSkeletonNoArcher { get; internal set; }
        public static ConfigEntry<bool>? SkeletonNoArcher { get; internal set; }
        public static void LootChestsNotBuildable(ConfigFile config)
        {
            (DefLootChests, LootChests) = new ConfigData<bool>("1 - Something", "Loot chest recipes not turned off", false)
            .Describe("Set to false, because they should not be buildable. \r\n" +
                "(false): Disable building chest pieces.\r\n" +
                "true: Enable building chest pieces.\r\n", null, "RaikoneerLocations", "Location")
            .Bind(config, false);
        }

        public static void Example(ConfigFile config)
        {
            (DefOrangeTree, OrangeTree) = new ConfigData<bool>("1 - Something", "OrangeTree", true)
            .Describe("If WildBosses is set to 1, this can be used. Allows specific disablers. \r\n" +
                "false: Disable XZ.\r\n" +
                "(true): Enable XZ.\r\n", null, "RaikoneerLocations", "Location")
            .Bind(config, true);
        }
        /*
        public static void Mobs(ConfigFile config)
        {
            (DefSkeletonNoArcher, SkeletonNoArcher) = MobConfig("SkeletonNoArcher", config);
        }
        public static (ConfigDefinition, ConfigEntry<bool>) MobConfig(string name, ConfigFile config, bool defaultEnabled = true)
        {
            return new ConfigData<bool>("3 - Monsters", $"{name}", true)
            .Describe("Toggle individual monsters. \r\n" +
                $"{(defaultEnabled ? "false" : "(false)")}: Disable {name}.\r\n" +
                $"{(defaultEnabled ? "(true)" : "true")}: Enable {name}.\r\n", null, "RaikoneerLocations", "Monster", "Creature")
            .Bind(config, defaultEnabled);
        }*/
    }
}