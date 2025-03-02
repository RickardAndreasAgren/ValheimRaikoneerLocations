

using LocationManager;
using ItemManager;
using UnityEngine;
using System.Collections.Generic;
using System;
using System.Linq;
using RaikoneerLocations.Spawners;

namespace RaikoneerLocations.PrefabIniters
{
    public static class ProcessAssets
    {
        private static bool donePrefabs = false;
        private static bool donePieces = false;
        private static bool doneLocations = false;
        public static void RunPrefabs()
        {
            if (donePrefabs) return;
            try
            {
                LoadPrefabs();
            }
            catch (System.Exception ex)
            {
                RaikoneerLocations.PluginLogger.LogWarning($"Fault while loading ARL prefabs: {ex}");
            }
        }
        public static void RunPieces()
        {
            if (donePieces) return;
            try
            {
                LoadPieces();
            }
            catch (System.Exception ex)
            {
                RaikoneerLocations.PluginLogger.LogWarning($"Fault while loading ARL prefabs: {ex}");
            }
        }
        public static void RunLocations()
        {
            if (doneLocations) return;
            try
            {
                LoadLocations();
            }
            catch (System.Exception ex)
            {
                RaikoneerLocations.PluginLogger.LogWarning($"Fault while loading ARL locations: {ex}");
            }
        }

        private static void LoadPrefabs()
        {
            /*
            var customSpawner = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/CustomSpawner.prefab");
            PrefabManager.RegisterPrefab(customSpawner);
            */
            donePrefabs = true;
        }

        private static void LoadPieces()
        {
            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_01MeadowsAdv.prefab");
            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_02MeadowsTreasure.prefab");
            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_03MeadowsArmory.prefab");
            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_11BlackForestBasic.prefab");

            /*
            var c01MeadowsAdv = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_01MeadowsAdv.prefab");
            c01MeadowsAdv.name = "arl_01MeadowsAdv";
            PrefabManager.RegisterPrefab(c01MeadowsAdv);

            var c02MeadowsTreasure = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_02MeadowsTreasure.prefab");
            c02MeadowsTreasure.name = "arl_02MeadowsTreasure";
            PrefabManager.RegisterPrefab(c02MeadowsTreasure);

            var c03MeadowsArmory = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_03MeadowsArmory.prefab");
            c03MeadowsArmory.name = "arl_03MeadowsArmory";
            PrefabManager.RegisterPrefab(c03MeadowsArmory);

            var c11BlackForestBasic = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_11BlackForestBasic.prefab");
            c11BlackForestBasic.name = "arl_11BlackForestBasic";
            PrefabManager.RegisterPrefab(c11BlackForestBasic);
            */

            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_12BlackForestAdv.prefab");
            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_13BlackForestTreasure.prefab");
            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_14BlackForestArmory.prefab");
            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_21SwampBasic.prefab");
            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_22SwampAdv.prefab");
            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_23SwampArmory.prefab");

            /*
            var c12BlackForestAdv = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_12BlackForestAdv.prefab");
            c12BlackForestAdv.name = "arl_12BlackForestAdv";
            PrefabManager.RegisterPrefab(c12BlackForestAdv);

            var c13BlackForestTreasure = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_13BlackForestTreasure.prefab");
            c13BlackForestTreasure.name = "arl_13BlackForestTreasure";
            PrefabManager.RegisterPrefab(c13BlackForestTreasure);

            var c14BlackForestArmory = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_14BlackForestArmory.prefab");
            c14BlackForestArmory.name = "arl_14BlackForestArmory";
            PrefabManager.RegisterPrefab(c14BlackForestArmory);

            var c21SwampBasic = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_21SwampBasic.prefab");
            c21SwampBasic.name = "arl_21SwampBasic";
            PrefabManager.RegisterPrefab(c21SwampBasic);

            var c22SwampAdv = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_22SwampAdv.prefab");
            c22SwampAdv.name = "arl_22SwampAdv";
            PrefabManager.RegisterPrefab(c22SwampAdv);

            var c23SwampArmory = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_23SwampArmory.prefab");
            c23SwampArmory.name = "arl_23SwampArmory";
            PrefabManager.RegisterPrefab(c23SwampArmory);
            */

            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_31MountainsBasic.prefab");
            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_32MountainsArmory.prefab");
            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_41PlainsBasic.prefab");
            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_42PlainsAdv.prefab");
            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_43PlainsTreasure.prefab");
            PieceManager.PiecePrefabManager.RegisterPrefab(RaikoneerLocations.EmbeddedResourceBundle, "arl_44PlainsArmory.prefab");

            /*
            var c31MountainsBasic = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_31MountainsBasic.prefab");
            c31MountainsBasic.name = "arl_31MountainsBasic";
            PrefabManager.RegisterPrefab(c31MountainsBasic);

            var c32MountainsArmory = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_32MountainsArmory.prefab");
            c32MountainsArmory.name = "arl_32MountainsArmory";
            PrefabManager.RegisterPrefab(c32MountainsArmory);

            var c41PlainsBasic = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_41PlainsBasic.prefab");
            c41PlainsBasic.name = "arl_41PlainsBasic";
            PrefabManager.RegisterPrefab(c41PlainsBasic);

            var c42PlainsAdv = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_42PlainsAdv.prefab");
            c42PlainsAdv.name = "arl_42PlainsAdv";
            PrefabManager.RegisterPrefab(c42PlainsAdv);

            var c43PlainsTreasure = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_43PlainsTreasure.prefab");
            c43PlainsTreasure.name = "arl_43PlainsTreasure";
            PrefabManager.RegisterPrefab(c43PlainsTreasure);

            var c44PlainsArmory = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_44PlainsArmory.prefab");
            c44PlainsArmory.name = "arl_44PlainsArmory";
            PrefabManager.RegisterPrefab(c44PlainsArmory);
            */
            donePieces = true;
        }

        private static void LoadLocations()
        {
            var arl_foresthold = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_foresthold.prefab");
            UpdateSpawnerRefs(ref arl_foresthold, "foresthold", SpawnDefinitions.SpawnerMap["arl_foresthold"]);
            _ = new LocationManager.Location(arl_foresthold)
            {
                Biome = Heightmap.Biome.BlackForest,
                SpawnArea = Heightmap.BiomeArea.Edge,
                Count = 15,
                Prioritize = false,
                SpawnAltitude = new Range((float)20, (float)100),
                SpawnDistance = new Range(3000, 5500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_foresthold",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random
            };

            var arl_foresthold_deserted = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_foresthold_deserted.prefab");
            UpdateSpawnerRefs(ref arl_foresthold_deserted,"foresthold_deserted", SpawnDefinitions.SpawnerMap["arl_foresthold_deserted"]);
            _ = new LocationManager.Location(arl_foresthold_deserted)
            {
                Biome = Heightmap.Biome.BlackForest,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)20, (float)100),
                SpawnDistance = new Range(2500, 4500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_foresthold",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random
            };

            var arl_foresthold_remnant = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_foresthold_remnant.prefab");
            UpdateSpawnerRefs(ref arl_foresthold_remnant,"foresthold_remnant" , SpawnDefinitions.SpawnerMap["arl_foresthold_remnant"]);
            _ = new LocationManager.Location(arl_foresthold_remnant)
            {
                Biome = Heightmap.Biome.Meadows,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)20, (float)100),
                SpawnDistance = new Range(2000, 4000),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_foresthold",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random
            };

            var arl_foresthold_ruins = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_foresthold_ruins.prefab");
            UpdateSpawnerRefs(ref arl_foresthold_ruins,"foresthold_ruins" , SpawnDefinitions.SpawnerMap["arl_foresthold_ruins"]);
            _ = new LocationManager.Location(arl_foresthold_ruins)
            {
                Biome = Heightmap.Biome.Mountain,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)80, (float)300),
                SpawnDistance = new Range(3000, 6000),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_foresthold",
                HeightDelta = new Range(0, 4),
                Rotation = Rotation.Random
            };

            var arl_instairtower = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_instairtower.prefab");
            UpdateSpawnerRefs(ref arl_instairtower,"instairtower" , SpawnDefinitions.SpawnerMap["arl_instairtower"]);
            _ = new LocationManager.Location(arl_instairtower)
            {
                Biome = Heightmap.Biome.Plains,
                SpawnArea = Heightmap.BiomeArea.Edge,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)15, (float)100),
                SpawnDistance = new Range(3500, 5000),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_instairtower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random
            };

            var arl_instairtower_damaged = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_instairtower_damaged.prefab");
            UpdateSpawnerRefs(ref arl_instairtower_damaged,"instairtower_damaged" , SpawnDefinitions.SpawnerMap["arl_instairtower_damaged"]);
            _ = new LocationManager.Location(arl_instairtower_damaged)
            {
                Biome = Heightmap.Biome.Plains,
                SpawnArea = Heightmap.BiomeArea.Edge,
                Count = 15,
                Prioritize = false,
                SpawnAltitude = new Range((float)15, (float)100),
                SpawnDistance = new Range(4000, 6000),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_instairtower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random
            };

            var arl_instairtower_rebuilt = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_instairtower_rebuilt.prefab");
            UpdateSpawnerRefs(ref arl_instairtower_rebuilt,"instairtower_rebuilt" , SpawnDefinitions.SpawnerMap["arl_instairtower_rebuilt"]);
            _ = new LocationManager.Location(arl_instairtower_rebuilt)
            {
                Biome = Heightmap.Biome.Plains,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)15, (float)100),
                SpawnDistance = new Range(3500, 5000),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_instairtower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random
            };

            var arl_instairtower_remnant = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_instairtower_remnant.prefab");
            UpdateSpawnerRefs(ref arl_instairtower_remnant,"instairtower_remnant" , SpawnDefinitions.SpawnerMap["arl_instairtower_remnant"]);
            _ = new LocationManager.Location(arl_instairtower_remnant)
            {
                Biome = Heightmap.Biome.Meadows,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 15,
                Prioritize = false,
                SpawnAltitude = new Range((float)15, (float)100),
                SpawnDistance = new Range(2000, 7500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_instairtower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random
            };

            var arl_instairtower_reruin = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_instairtower_reruin.prefab");
            UpdateSpawnerRefs(ref arl_instairtower_reruin,"instairtower_reruin" , SpawnDefinitions.SpawnerMap["arl_instairtower_reruin"]);
            _ = new LocationManager.Location(arl_instairtower_reruin)
            {
                Biome = Heightmap.Biome.Plains,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 15,
                Prioritize = false,
                SpawnAltitude = new Range((float)15, (float)100),
                SpawnDistance = new Range(4000, 6000),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_instairtower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random
            };

            var arl_instairtower_ruin = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_instairtower_ruin.prefab");
            UpdateSpawnerRefs(ref arl_instairtower_ruin,"instairtower_ruin" , SpawnDefinitions.SpawnerMap["arl_instairtower_ruin"]);
            _ = new LocationManager.Location(arl_instairtower_ruin)
            {
                Biome = Heightmap.Biome.BlackForest,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 15,
                Prioritize = false,
                SpawnAltitude = new Range((float)15, (float)100),
                SpawnDistance = new Range(2500, 5000),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_instairtower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                ForestThreshold = new Range(0,1)
            };

            var arl_jarlsmanshouse = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_jarlsmanshouse.prefab");
            UpdateSpawnerRefs(ref arl_jarlsmanshouse,"jarlsmanshouse" , SpawnDefinitions.SpawnerMap["arl_jarlsmanshouse"]);
            _ = new LocationManager.Location(arl_jarlsmanshouse)
            {
                Biome = Heightmap.Biome.Meadows,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 8,
                Prioritize = false,
                SpawnAltitude = new Range((float)20, (float)60),
                SpawnDistance = new Range(2000, 5000),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_jarlsmanshouse",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(0, 1)
            };

            var arl_jarlsmanshouse_remnant = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_jarlsmanshouse_remnant.prefab");
            UpdateSpawnerRefs(ref arl_jarlsmanshouse_remnant,"jarlsmanshouse_remnant" , SpawnDefinitions.SpawnerMap["arl_jarlsmanshouse_remnant"]);
            _ = new LocationManager.Location(arl_jarlsmanshouse_remnant)
            {
                Biome = Heightmap.Biome.Meadows,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 8,
                Prioritize = false,
                SpawnAltitude = new Range((float)20, (float)60),
                SpawnDistance = new Range(2000, 5000),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_jarlsmanshouse",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(0, 1)
            };

            var arl_jarlsmanshouse_ruin = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_jarlsmanshouse_ruin.prefab");
            // UpdateSpawnerRefs(ref arl_jarlsmanshouse_ruin,"jarlsmanshouse_ruin" , SpawnDefinitions.SpawnerMap["arl_jarlsmanshouse_ruin"]);
            _ = new LocationManager.Location(arl_jarlsmanshouse_ruin)
            {
                Biome = Heightmap.Biome.Meadows,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 14,
                Prioritize = false,
                SpawnAltitude = new Range((float)20, (float)60),
                SpawnDistance = new Range(2000, 5000),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_jarlsmanshouse",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(0, 1)
            };

            var arl_outpostcabin = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_outpostcabin.prefab");
            UpdateSpawnerRefs(ref arl_outpostcabin,"outpostcabin" , SpawnDefinitions.SpawnerMap["arl_outpostcabin"]);
            _ = new LocationManager.Location(arl_outpostcabin)
            {
                Biome = Heightmap.Biome.Mountain,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)90, (float)200),
                SpawnDistance = new Range(1000, 4500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_outpostcabin",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                ForestThreshold = new Range(1, 0)
            };

            var arl_outpostcabin_ruin = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_outpostcabin_ruin.prefab");
            UpdateSpawnerRefs(ref arl_outpostcabin_ruin,"outpostcabin_ruin" , SpawnDefinitions.SpawnerMap["arl_outpostcabin_ruin"]);
            _ = new LocationManager.Location(arl_outpostcabin_ruin)
            {
                Biome = Heightmap.Biome.Mountain,
                SpawnArea = Heightmap.BiomeArea.Edge,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)50, (float)100),
                SpawnDistance = new Range(1000, 4500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_outpostcabin",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                ForestThreshold = new Range(1, 0)
            };

            var arl_outposttower = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_outposttower.prefab");
            UpdateSpawnerRefs(ref arl_outposttower,"outposttower" , SpawnDefinitions.SpawnerMap["arl_outposttower"]);
            _ = new LocationManager.Location(arl_outposttower)
            {
                Biome = Heightmap.Biome.BlackForest,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 15,
                Prioritize = false,
                SpawnAltitude = new Range((float)30, (float)100),
                SpawnDistance = new Range(2000, 4000),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_outposttower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_outposttower_burnt = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_outposttower_burnt.prefab");
            UpdateSpawnerRefs(ref arl_outposttower_burnt,"outposttower_burnt" , SpawnDefinitions.SpawnerMap["arl_outposttower_burnt"]);
            _ = new LocationManager.Location(arl_outposttower_burnt)
            {
                Biome = Heightmap.Biome.Plains,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)30, (float)100),
                SpawnDistance = new Range(500, 5500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_outposttower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_outposttower_ruin = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_outposttower_ruin.prefab");
            UpdateSpawnerRefs(ref arl_outposttower_ruin,"outposttower_ruin" , SpawnDefinitions.SpawnerMap["arl_outposttower_ruin"]);
            _ = new LocationManager.Location(arl_outposttower_ruin)
            {
                Biome = Heightmap.Biome.Plains,
                SpawnArea = Heightmap.BiomeArea.Edge,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)30, (float)100),
                SpawnDistance = new Range(500, 5500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_outposttower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_outposttower_remnant = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_outposttower_remnant.prefab");
            UpdateSpawnerRefs(ref arl_outposttower_remnant,"outposttower_remnant" , SpawnDefinitions.SpawnerMap["arl_outposttower_remnant"]);
            _ = new LocationManager.Location(arl_outposttower_remnant)
            {
                Biome = Heightmap.Biome.Plains,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)30, (float)100),
                SpawnDistance = new Range(500, 5500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_outposttower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_pillartower = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_pillartower.prefab");
            UpdateSpawnerRefs(ref arl_pillartower,"pillartower" , SpawnDefinitions.SpawnerMap["arl_pillartower"]);
            _ = new LocationManager.Location(arl_pillartower)
            {
                Biome = Heightmap.Biome.Plains,
                SpawnArea = Heightmap.BiomeArea.Edge,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)30, (float)100),
                SpawnDistance = new Range(500, 5500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_pillartower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_pillartower_remnant = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_pillartower_remnant.prefab");
            UpdateSpawnerRefs(ref arl_pillartower_remnant,"pillartower_remnant" , SpawnDefinitions.SpawnerMap["arl_pillartower_remnant"]);
            _ = new LocationManager.Location(arl_pillartower_remnant)
            {
                Biome = Heightmap.Biome.Plains,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 15,
                Prioritize = false,
                SpawnAltitude = new Range((float)20, (float)100),
                SpawnDistance = new Range(500, 5500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_pillartower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_pillartower_ruin = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_pillartower_ruin.prefab");
            UpdateSpawnerRefs(ref arl_pillartower_ruin,"pillartower_ruin" , SpawnDefinitions.SpawnerMap["arl_pillartower_ruin"]);
            _ = new LocationManager.Location(arl_pillartower_ruin)
            {
                Biome = Heightmap.Biome.Swamp,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)2, (float)100),
                SpawnDistance = new Range(500, 7500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_pillartower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_smallonghouse = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_smallonghouse.prefab");
            UpdateSpawnerRefs(ref arl_smallonghouse,"smallonghouse" , SpawnDefinitions.SpawnerMap["arl_smallonghouse"]);
            _ = new LocationManager.Location(arl_smallonghouse)
            {
                Biome = Heightmap.Biome.Meadows,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 15,
                Prioritize = false,
                SpawnAltitude = new Range((float)5, (float)100),
                SpawnDistance = new Range(400, 2500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_smallonghouse",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_swamptower = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_swamptower.prefab");
            UpdateSpawnerRefs(ref arl_swamptower,"swamptower" , SpawnDefinitions.SpawnerMap["arl_swamptower"]);
            _ = new LocationManager.Location(arl_swamptower)
            {
                Biome = Heightmap.Biome.Swamp,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)2, (float)100),
                SpawnDistance = new Range(0, 7500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_swamptower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_swamptower_remnant = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_swamptower_remnant.prefab");
            UpdateSpawnerRefs(ref arl_swamptower_remnant,"swamptower_remnant" , SpawnDefinitions.SpawnerMap["arl_swamptower_remnant"]);
            _ = new LocationManager.Location(arl_swamptower_remnant)
            {
                Biome = Heightmap.Biome.Swamp,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 15,
                Prioritize = false,
                SpawnAltitude = new Range((float)2, (float)100),
                SpawnDistance = new Range(0, 7500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_swamptower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_swamptower_ruin = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_swamptower_ruin.prefab");
            UpdateSpawnerRefs(ref arl_swamptower_ruin,"swamptower_ruin" , SpawnDefinitions.SpawnerMap["arl_swamptower_ruin"]);
            _ = new LocationManager.Location(arl_swamptower_ruin)
            {
                Biome = Heightmap.Biome.Swamp,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 15,
                Prioritize = false,
                SpawnAltitude = new Range((float)2, (float)100),
                SpawnDistance = new Range(0, 7500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_swamptower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_traphouseplain = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_traphouseplain.prefab");
            UpdateSpawnerRefs(ref arl_traphouseplain,"traphouseplain" , SpawnDefinitions.SpawnerMap["arl_traphouseplain"]);
            _ = new LocationManager.Location(arl_traphouseplain)
            {
                Biome = Heightmap.Biome.Plains,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 8,
                Prioritize = false,
                SpawnAltitude = new Range((float)15, (float)100),
                SpawnDistance = new Range(0, 7500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_traphouseplain",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_traphouseplain_remnant = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_traphouseplain_remnant.prefab");
            UpdateSpawnerRefs(ref arl_traphouseplain_remnant,"traphouseplain_remnant" , SpawnDefinitions.SpawnerMap["arl_traphouseplain_remnant"]);
            _ = new LocationManager.Location(arl_traphouseplain_remnant)
            {
                Biome = Heightmap.Biome.Meadows,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 8,
                Prioritize = false,
                SpawnAltitude = new Range((float)15, (float)100),
                SpawnDistance = new Range(2000, 7500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_traphouseplain",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_traphouseplain_ruin = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_traphouseplain_ruin.prefab");
            UpdateSpawnerRefs(ref arl_traphouseplain_ruin,"traphouseplain_ruin" , SpawnDefinitions.SpawnerMap["arl_traphouseplain_ruin"]);
            _ = new LocationManager.Location(arl_traphouseplain_ruin)
            {
                Biome = Heightmap.Biome.Plains,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 8,
                Prioritize = false,
                SpawnAltitude = new Range((float)15, (float)100),
                SpawnDistance = new Range(0, 7500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_traphouseplain",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_twotwohouse = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_twotwohouse.prefab");
            UpdateSpawnerRefs(ref arl_twotwohouse,"twotwohouse" , SpawnDefinitions.SpawnerMap["arl_twotwohouse"]);
            _ = new LocationManager.Location(arl_twotwohouse)
            {
                Biome = Heightmap.Biome.Mountain,
                SpawnArea = Heightmap.BiomeArea.Edge,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)50, (float)100),
                SpawnDistance = new Range(1000, 3500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_twotwohouse",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 0)
            };

            var arl_twotwohouse_remnant = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_twotwohouse_remnant.prefab");
            UpdateSpawnerRefs(ref arl_twotwohouse_remnant,"twotwohouse_remnant" , SpawnDefinitions.SpawnerMap["arl_twotwohouse_remnant"]);
            _ = new LocationManager.Location(arl_twotwohouse_remnant)
            {
                Biome = Heightmap.Biome.Meadows,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 12,
                Prioritize = false,
                SpawnAltitude = new Range((float)25, (float)100),
                SpawnDistance = new Range(1000, 3500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_twotwohouse",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                ForestThreshold = new Range(1, 0)
            };

            var arl_twotwohouse_ruin = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_twotwohouse_ruin.prefab");
            UpdateSpawnerRefs(ref arl_twotwohouse_ruin,"twotwohouse_ruin" , SpawnDefinitions.SpawnerMap["arl_twotwohouse_ruin"]);
            _ = new LocationManager.Location(arl_twotwohouse_ruin)
            {
                Biome = Heightmap.Biome.Meadows,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 8,
                Prioritize = false,
                SpawnAltitude = new Range((float)15, (float)100),
                SpawnDistance = new Range(1000, 3500),
                MinimumDistanceFromGroup = 300,
                GroupName = "arl_twotwohouse",
                HeightDelta = new Range(0, 4),
                Rotation = Rotation.Random,
                ForestThreshold = new Range(1, 0)
            };

            var arl_twotwohouse_stormed = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>("assets/arl_twotwohouse_stormed.prefab");
            UpdateSpawnerRefs(ref arl_twotwohouse_stormed,"twotwohouse_stormed" , SpawnDefinitions.SpawnerMap["arl_twotwohouse_stormed"]);
            _ = new LocationManager.Location(arl_twotwohouse_stormed)
            {
                Biome = Heightmap.Biome.Mountain,
                SpawnArea = Heightmap.BiomeArea.Edge,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)50, (float)100),
                SpawnDistance = new Range(1000, 3500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_twotwohouse",
                HeightDelta = new Range(0, 5),
                Rotation = Rotation.Random,
                ForestThreshold = new Range(1, 0)
            };

            RaikoneerLocations.PluginLogger.LogMessage("ARL ran location loaders.");
            donePieces = true;
        }

        public static void A()
        {
            ZoneSystem.instance.GetLocation("Aha");
        }

        private static void UpdateSpawnerRefs(ref GameObject prefabRoot, string name, Dictionary<string, string> spawnerDefinitions)
        {
            // root => children.Tolower == Spawners => children.ToLower == spawnerObject => component spawner:target?
            var spawnersNode = prefabRoot.transform.Find("Spawners");
            string NullSpawners = "No spawnerParentNode";
            string NullTargetSpawner = "No target spawn with name: ";
            string NullCreatureSpawner = "No Creaturespawner";
            string NullLookup = "nothing from ZNetScene";
            RaikoneerLocations.PluginLogger.LogWarning($"{(spawnersNode != null ? spawnersNode.childCount.ToString() : NullSpawners)}");
            foreach (var targetSpawner in spawnerDefinitions.Keys)
            {
                RaikoneerLocations.PluginLogger.LogWarning("Target");
                RaikoneerLocations.PluginLogger.LogWarning(targetSpawner);
                RaikoneerLocations.PluginLogger.LogWarning($"Checking {name}_{targetSpawner}");

                var targetSpawnerT = spawnersNode.Find($"{name}_{targetSpawner}");
                RaikoneerLocations.PluginLogger.LogWarning($"{(targetSpawnerT != null ? targetSpawnerT.name : NullTargetSpawner)}");

                RaikoneerLocations.PluginLogger.LogWarning($"{targetSpawnerT.gameObject.name} named Object");
                RaikoneerLocations.PluginLogger.LogWarning($"{targetSpawnerT.gameObject.GetComponentCount()} component count on Object");
                RaikoneerLocations.PluginLogger.LogWarning($"{targetSpawnerT.gameObject.GetComponentCount()} object children");

                RaikoneerLocations.PluginLogger.LogWarning($"{targetSpawnerT.childCount} transform childCount");

                RaikoneerLocations.PluginLogger.LogWarning($"checking parent Components");
                var inParent = targetSpawnerT.GetComponentInParent(typeof(CreatureSpawner));
                if (inParent == null) RaikoneerLocations.PluginLogger.LogWarning($"no parent hits");
                else RaikoneerLocations.PluginLogger.LogWarning($"{inParent.name}");

                RaikoneerLocations.PluginLogger.LogWarning($"checking child Components");
                var inChildren = targetSpawnerT.GetComponentInChildren(typeof(CreatureSpawner));
                if (inChildren == null) RaikoneerLocations.PluginLogger.LogWarning($"no children hits");
                else RaikoneerLocations.PluginLogger.LogWarning($"{inChildren} transform children");

                RaikoneerLocations.PluginLogger.LogWarning($"checking current Components");
                var inCurrent = targetSpawnerT.GetComponentInChildren(typeof(CreatureSpawner));
                if (inCurrent == null) RaikoneerLocations.PluginLogger.LogWarning($"no current hits");
                else RaikoneerLocations.PluginLogger.LogWarning($"{inCurrent} transform current");

                CreatureSpawner creatureSpawner = targetSpawnerT.gameObject.GetComponent<CreatureSpawner>();

                RaikoneerLocations.PluginLogger.LogWarning($"{(creatureSpawner != null ? creatureSpawner.name : NullCreatureSpawner)}");
                if (ZNetScene.instance == null) RaikoneerLocations.PluginLogger.LogWarning("No ZNET");
                RaikoneerLocations.PluginLogger.LogWarning($"Looking up ${spawnerDefinitions[targetSpawner]}");
                GameObject updatedCreatureRef = ZNetScene.instance.m_prefabs
                    .First(gameObject => gameObject.name == spawnerDefinitions[targetSpawner]);
                RaikoneerLocations.PluginLogger.LogWarning($"Got ${(updatedCreatureRef != null ? updatedCreatureRef.name : NullLookup)}");
                creatureSpawner.m_creaturePrefab = updatedCreatureRef;
            }
        }
    }
    
}