
using System;
using System.Collections;
using System.Collections.Generic;

namespace Raikoneer.Locations.Spawners
{
    public static class SpawnDefinitions
    {
        public static void BuildMapDefault()
        {
            Foresthold();
            Foresthold_Deserted();
            Foresthold_Remnant();
            Foresthold_Ruins();

            Instairtower();
            Instairtower_Damaged();
            Instairtower_Rebuilt();
            Instairtower_Remnant();
            Instairtower_Reruin();
            Instairtower_Ruin();

            Jarlsmanshouse();
            Jarlsmanshouse_Remnant();
            Jarlsmanshouse_Ruin();

            Outpostcabin();
            Outpostcabin_ruin();

            Outposttower();
            Outposttower_Burnt();
            Outposttower_Remnant();
            Outposttower_Ruin();

            Pillartower();
            Pillartower_Remnant();
            Pillartower_Ruin();

            Smallonghouse();

            Swamptower();
            Swamptower_Remnant();
            Swamptower_Ruin();

            Traphouseplain();
            Traphouseplain_Remnant();
            Traphouseplain_Ruin();

            TwoTwoHouse();
            TwoTwoHouse_Remnant();
            TwoTwoHouse_Ruin();
            TwoTwoHouse_Stormed();
        }

        private static void TwoTwoHouse_Stormed()
        {
            string locationName = "arl_twotwohouse_stormed";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.GreydwarfElite, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Greydwarf, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.GreydwarfSpawner, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.GreydwarfElite, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.GreydwarfShaman, locationName, "spawn5"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void TwoTwoHouse_Ruin()
        {
            string locationName = "arl_twotwohouse_ruin";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn2"));
            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void TwoTwoHouse_Remnant()
        {
            string locationName = "arl_twotwohouse_remnant";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Greyling, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Neck, locationName, "spawn2"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void TwoTwoHouse()
        {
            string locationName = "arl_twotwohouse";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Cultist, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Ulv, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.Ulv, locationName, "spawn3"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Traphouseplain_Ruin()
        {
            string locationName = "arl_traphouseplain_ruin";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.GoblinBrute, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Goblin, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Goblin, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.Goblin, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.Goblin, locationName, "spawn6"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Traphouseplain_Remnant()
        {
            string locationName = "arl_traphouseplain_remnant";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Boar, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Neck, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.Boar, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Neck, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.Boar, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.Boar, locationName, "spawn6"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Traphouseplain()
        {
            string locationName = "arl_traphouseplain";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Wraith, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Wraith, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.BlobTar, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.DraugrElite, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.DraugrElite, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.Wraith, locationName, "spawn6"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Swamptower_Ruin()
        {
            string locationName = "arl_swamptower_ruin";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Draugr, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Draugr, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.Draugr, locationName, "spawn5"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Swamptower_Remnant()
        {
            string locationName = "arl_swamptower_remnant";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Wraith, locationName, "spawn1"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Swamptower()
        {
            string locationName = "arl_swamptower";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Wraith, locationName, "spawn1"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Smallonghouse()
        {
            string locationName = "arl_smallonghouse";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn3"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Pillartower_Ruin()
        {
            string locationName = "arl_pillartower_ruin";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.DraugrElite, locationName, "spawn3"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Pillartower_Remnant()
        {
            string locationName = "arl_pillartower_remnant";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Deathsquito, locationName, "spawn1"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Pillartower()
        {
            string locationName = "arl_pillartower";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.Goblin, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.GoblinShaman, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.Goblin, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.Goblin, locationName, "spawn6"));
            slist.Add("spawn7", new(PrefabInventoryMonsters.Goblin, locationName, "spawn7"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Outposttower_Ruin()
        {
            string locationName = "arl_outposttower_ruin";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Goblin, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.Goblin, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.Goblin, locationName, "spawn5"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Outposttower_Remnant()
        {
            string locationName = "arl_outposttower_remnant";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Goblin, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.Goblin, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.Goblin, locationName, "spawn5"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Outposttower_Burnt()
        {
            string locationName = "arl_outposttower_burnt";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Goblin, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.Goblin, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.Goblin, locationName, "spawn5"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Outposttower()
        {
            string locationName = "arl_outposttower";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Draugr, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.Ghost, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn6"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Outpostcabin_ruin()
        {
            string locationName = "arl_outpostcabin_ruin";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Drake, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Drake, locationName, "spawn2"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Outpostcabin()
        {
            string locationName = "arl_outpostcabin";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Wolf, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Wolf, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.Wolf, locationName, "spawn3"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Jarlsmanshouse_Ruin()
        {
            string locationName = "arl_jarlsmanshouse_ruin";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Draugr, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Ghost, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn6"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Jarlsmanshouse_Remnant()
        {
            string locationName = "arl_jarlsmanshouse_remnant";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Draugr, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Ghost, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn6"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Jarlsmanshouse()
        {
            string locationName = "arl_jarlsmanshouse";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Wraith, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn3"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Instairtower_Ruin()
        {
            string locationName = "arl_instairtower_ruin";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Greydwarf, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Greydwarf, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.GreydwarfShaman, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Greydwarf, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.Greydwarf, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.Greydwarf, locationName, "spawn6"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Instairtower_Reruin()
        {
            string locationName = "arl_instairtower_reruin";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.GoblinShaman, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Goblin, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.Goblin, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.Goblin, locationName, "spawn6"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Instairtower_Remnant()
        {
            string locationName = "arl_instairtower_remnant";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Draugr, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn4"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Instairtower_Rebuilt()
        {
            string locationName = "arl_instairtower_rebuilt";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.GoblinShaman, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Goblin, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.Goblin, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.Goblin, locationName, "spawn6"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Instairtower_Damaged()
        {
            string locationName = "arl_instairtower_damaged";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.GoblinShaman, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Goblin, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.Goblin, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.Goblin, locationName, "spawn6"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Instairtower()
        {
            string locationName = "arl_instairtower";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.GoblinSpearman, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.GoblinShaman, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Goblin, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.Goblin, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.Goblin, locationName, "spawn6"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Foresthold_Ruins()
        {
            string locationName = "arl_foresthold_ruins";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn5"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Foresthold_Remnant()
        {
            string locationName = "arl_foresthold_remnant";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Draugr, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn6"));
            slist.Add("spawn7", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn7"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        private static void Foresthold_Deserted()
        {
            string locationName = "arl_foresthold_deserted";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Draugr, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn6"));
            slist.Add("spawn7", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn7"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }

        public static void Foresthold()
        {
            string locationName = "arl_foresthold";
            var slist = new Dictionary<string, CreatureSpawnerNameConfig>();
            slist.Add("spawn1", new(PrefabInventoryMonsters.Draugr, locationName, "spawn1"));
            slist.Add("spawn2", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn2"));
            slist.Add("spawn3", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn3"));
            slist.Add("spawn4", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn4"));
            slist.Add("spawn5", new(PrefabInventoryMonsters.SkeletonMelee, locationName, "spawn5"));
            slist.Add("spawn6", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn6"));
            slist.Add("spawn7", new(PrefabInventoryMonsters.Skeleton, locationName, "spawn7"));

            PluginConfig.SpawnerMap[locationName] = slist;
        }
    }
}