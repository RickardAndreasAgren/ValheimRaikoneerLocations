
using System;
using System.Collections;
using System.Collections.Generic;

namespace RaikoneerLocations.Spawners
{
    public static class SpawnDefinitions
    {
        public static Dictionary<string, Dictionary<string, string>> SpawnerMap = new();

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
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.GreydwarfElite);
            slist.Add("spawn2", PrefabInventoryMonsters.Greydwarf);
            slist.Add("spawn3", PrefabInventoryMonsters.GreydwarfSpawner);
            slist.Add("spawn4", PrefabInventoryMonsters.GreydwarfElite);
            slist.Add("spawn5", PrefabInventoryMonsters.GreydwarfShaman);

            SpawnerMap["arl_twotwohouse_stormed"] = slist;
        }

        private static void TwoTwoHouse_Ruin()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.SkeletonMelee);
            slist.Add("spawn2", PrefabInventoryMonsters.Skeleton);

            SpawnerMap["arl_twotwohouse_ruin"] = slist;
        }

        private static void TwoTwoHouse_Remnant()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Greyling);
            slist.Add("spawn2", PrefabInventoryMonsters.Neck);

            SpawnerMap["arl_twotwohouse_remnant"] = slist;
        }

        private static void TwoTwoHouse()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Cultist);
            slist.Add("spawn2", PrefabInventoryMonsters.Ulv);
            slist.Add("spawn3", PrefabInventoryMonsters.Ulv);

            SpawnerMap["arl_twotwohouse"] = slist;
        }

        private static void Traphouseplain_Ruin()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.GoblinBrute);
            slist.Add("spawn2", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn3", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn4", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn5", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn6", PrefabInventoryMonsters.Goblin);

            SpawnerMap["arl_traphouseplain_ruin"] = slist;
        }

        private static void Traphouseplain_Remnant()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Boar);
            slist.Add("spawn2", PrefabInventoryMonsters.Neck);
            slist.Add("spawn3", PrefabInventoryMonsters.Boar);
            slist.Add("spawn4", PrefabInventoryMonsters.Neck);
            slist.Add("spawn5", PrefabInventoryMonsters.Boar);
            slist.Add("spawn6", PrefabInventoryMonsters.Boar);

            SpawnerMap["arl_traphouseplain_remnant"] = slist;
        }

        private static void Traphouseplain()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Wraith);
            slist.Add("spawn2", PrefabInventoryMonsters.Wraith);
            slist.Add("spawn3", PrefabInventoryMonsters.BlobTar);
            slist.Add("spawn4", PrefabInventoryMonsters.DraugrElite);
            slist.Add("spawn5", PrefabInventoryMonsters.DraugrElite);
            slist.Add("spawn6", PrefabInventoryMonsters.Wraith);

            SpawnerMap["arl_traphouseplain"] = slist;
        }

        private static void Swamptower_Ruin()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn2", PrefabInventoryMonsters.Draugr);
            slist.Add("spawn3", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn4", PrefabInventoryMonsters.Draugr);
            slist.Add("spawn5", PrefabInventoryMonsters.Draugr);

            SpawnerMap["arl_swamptower_ruin"] = slist;
        }

        private static void Swamptower_Remnant()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Wraith);

            SpawnerMap["arl_swamptower_remnant"] = slist;
        }

        private static void Swamptower()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Wraith);

            SpawnerMap["arl_swamptower"] = slist;
        }

        private static void Smallonghouse()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.SkeletonMelee);
            slist.Add("spawn2", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn3", PrefabInventoryMonsters.Skeleton);

            SpawnerMap["arl_smallonghouse"] = slist;
        }

        private static void Pillartower_Ruin()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn2", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn3", PrefabInventoryMonsters.DraugrElite);

            SpawnerMap["arl_pillartower_ruin"] = slist;
        }

        private static void Pillartower_Remnant()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Deathsquito);

            SpawnerMap["arl_pillartower_remnant"] = slist;
        }

        private static void Pillartower()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn2", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn3", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn4", PrefabInventoryMonsters.GoblinShaman);
            slist.Add("spawn5", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn6", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn7", PrefabInventoryMonsters.Goblin);

            SpawnerMap["arl_pillartower"] = slist;
        }

        private static void Outposttower_Ruin()
        {

            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn2", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn3", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn4", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn5", PrefabInventoryMonsters.Goblin);

            SpawnerMap["arl_outposttower_ruin"] = slist;
        }

        private static void Outposttower_Remnant()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn2", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn3", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn4", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn5", PrefabInventoryMonsters.Goblin);

            SpawnerMap["arl_outposttower_remnant"] = slist;
        }

        private static void Outposttower_Burnt()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn2", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn3", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn4", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn5", PrefabInventoryMonsters.Goblin);

            SpawnerMap["arl_outposttower_burnt"] = slist;
        }

        private static void Outposttower()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Draugr);
            slist.Add("spawn2", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn3", PrefabInventoryMonsters.Ghost);
            slist.Add("spawn4", PrefabInventoryMonsters.SkeletonMelee);
            slist.Add("spawn5", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn6", PrefabInventoryMonsters.SkeletonMelee);

            SpawnerMap["arl_outposttower"] = slist;
        }

        private static void Outpostcabin_ruin()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Drake);
            slist.Add("spawn2", PrefabInventoryMonsters.Drake);

            SpawnerMap["arl_outpostcabin_ruin"] = slist;
        }

        private static void Outpostcabin()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Wolf);
            slist.Add("spawn2", PrefabInventoryMonsters.Wolf);
            slist.Add("spawn3", PrefabInventoryMonsters.Wolf);

            SpawnerMap["arl_outpostcabin"] = slist;
        }

        private static void Jarlsmanshouse_Ruin()
        {
            return;
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn2", PrefabInventoryMonsters.Draugr);
            slist.Add("spawn3", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn4", PrefabInventoryMonsters.Ghost);
            slist.Add("spawn5", PrefabInventoryMonsters.SkeletonMelee);
            slist.Add("spawn6", PrefabInventoryMonsters.Skeleton);

            SpawnerMap["arl_jarlsmanshouse_ruin"] = slist;
        }

        private static void Jarlsmanshouse_Remnant()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn2", PrefabInventoryMonsters.Draugr);
            slist.Add("spawn3", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn4", PrefabInventoryMonsters.Ghost);
            slist.Add("spawn5", PrefabInventoryMonsters.SkeletonMelee);
            slist.Add("spawn6", PrefabInventoryMonsters.Skeleton);

            SpawnerMap["arl_jarlsmanshouse_remnant"] = slist;
        }

        private static void Jarlsmanshouse()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Wraith);
            slist.Add("spawn2", PrefabInventoryMonsters.SkeletonMelee);
            slist.Add("spawn3", PrefabInventoryMonsters.SkeletonMelee);

            SpawnerMap["arl_jarlsmanshouse"] = slist;
        }

        private static void Instairtower_Ruin()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Greydwarf);
            slist.Add("spawn2", PrefabInventoryMonsters.Greydwarf);
            slist.Add("spawn3", PrefabInventoryMonsters.GreydwarfShaman);
            slist.Add("spawn4", PrefabInventoryMonsters.Greydwarf);
            slist.Add("spawn5", PrefabInventoryMonsters.Greydwarf);
            slist.Add("spawn6", PrefabInventoryMonsters.Greydwarf);

            SpawnerMap["arl_instairtower_ruin"] = slist;
        }

        private static void Instairtower_Reruin()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn2", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn3", PrefabInventoryMonsters.GoblinShaman);
            slist.Add("spawn4", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn5", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn6", PrefabInventoryMonsters.Goblin);

            SpawnerMap["arl_instairtower_reruin"] = slist;
        }

        private static void Instairtower_Remnant()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Draugr);
            slist.Add("spawn2", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn3", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn4", PrefabInventoryMonsters.Skeleton);

            SpawnerMap["arl_instairtower_remnant"] = slist;
        }

        private static void Instairtower_Rebuilt()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn2", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn3", PrefabInventoryMonsters.GoblinShaman);
            slist.Add("spawn4", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn5", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn6", PrefabInventoryMonsters.Goblin);

            SpawnerMap["arl_instairtower_rebuilt"] = slist;
        }

        private static void Instairtower_Damaged()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn2", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn3", PrefabInventoryMonsters.GoblinShaman);
            slist.Add("spawn4", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn5", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn6", PrefabInventoryMonsters.Goblin);

            SpawnerMap["arl_instairtower_damaged"] = slist;
        }

        private static void Instairtower()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn2", PrefabInventoryMonsters.GoblinSpearman);
            slist.Add("spawn3", PrefabInventoryMonsters.GoblinShaman);
            slist.Add("spawn4", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn5", PrefabInventoryMonsters.Goblin);
            slist.Add("spawn6", PrefabInventoryMonsters.Goblin);

            SpawnerMap["arl_instairtower"] = slist;
        }

        private static void Foresthold_Ruins()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn2", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn3", PrefabInventoryMonsters.SkeletonMelee);
            slist.Add("spawn4", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn5", PrefabInventoryMonsters.SkeletonMelee);

            SpawnerMap["arl_foresthold_ruins"] = slist;
        }

        private static void Foresthold_Remnant()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Draugr);
            slist.Add("spawn2", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn3", PrefabInventoryMonsters.SkeletonMelee);
            slist.Add("spawn4", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn5", PrefabInventoryMonsters.SkeletonMelee);
            slist.Add("spawn6", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn7", PrefabInventoryMonsters.Skeleton);

            SpawnerMap["arl_foresthold_remnant"] = slist;
        }

        private static void Foresthold_Deserted()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Draugr);
            slist.Add("spawn2", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn3", PrefabInventoryMonsters.SkeletonMelee);
            slist.Add("spawn4", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn5", PrefabInventoryMonsters.SkeletonMelee);
            slist.Add("spawn6", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn7", PrefabInventoryMonsters.Skeleton);

            SpawnerMap["arl_foresthold_deserted"] = slist;
        }

        public static void Foresthold()
        {
            var slist = new Dictionary<string, string>();
            slist.Add("spawn1", PrefabInventoryMonsters.Draugr);
            slist.Add("spawn2", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn3", PrefabInventoryMonsters.SkeletonMelee);
            slist.Add("spawn4", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn5", PrefabInventoryMonsters.SkeletonMelee);
            slist.Add("spawn6", PrefabInventoryMonsters.Skeleton);
            slist.Add("spawn7", PrefabInventoryMonsters.Skeleton);

            SpawnerMap["arl_foresthold"] = slist;
        }
    }
}