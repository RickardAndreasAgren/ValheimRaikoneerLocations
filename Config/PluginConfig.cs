extern alias ServerSyncStandalone;

using BepInEx.Configuration;
using static UnityEngine.EventSystems.EventTrigger;

namespace RaikoneerLocations
{
    public static class PluginConfig
    {
        public static void BindConfig(ConfigFile config)
        {
            Example(config);
        }

        public static ConfigDefinition? DefOrangeTree { get; internal set; }
        public static ConfigEntry<bool>? OrangeTree { get; internal set; }
        public static ConfigDefinition? DefSkeletonNoArcher { get; internal set; }
        public static ConfigEntry<bool>? SkeletonNoArcher { get; internal set; }
        
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