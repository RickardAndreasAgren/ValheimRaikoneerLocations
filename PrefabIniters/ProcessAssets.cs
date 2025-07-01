
using LocationManager;
using ItemManager;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using Raikoneer.Locations.Spawners;
using PieceManager;
using static Heightmap;
using static MeleeWeaponTrail;
using System;

namespace Raikoneer.Locations.PrefabIniters
{
    public static class ProcessAssets
    {
        private static bool donePrefabs = false;
        private static bool donePieces = false;
        private static bool doneLocations = false;
        private static ZNetScene? zNet { get; set; } = null;
        public static void RunPrefabs()
        {
            if (donePrefabs) return;
            try
            {
                donePrefabs = true;
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

        public static void UpdateLocationSpawners(ZNetScene instance)
        {
            zNet = instance;
            FixSpawners();
        }

        private static void LoadPieces()
        {
            var arl_01 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_01MeadowsAdv.prefab");
            SetLootChestPiece(arl_01);
            var arl_02 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_02MeadowsTreasure.prefab");
            SetLootChestPiece(arl_02);
            var arl_03 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_03MeadowsArmory.prefab");
            SetLootChestPiece(arl_03);
            var arl_11 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_11BlackForestBasic.prefab");
            SetLootChestPiece(arl_11);
            var arl_12 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_12BlackForestAdv.prefab");
            SetLootChestPiece(arl_12);
            var arl_13 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_13BlackForestTreasure.prefab");
            SetLootChestPiece(arl_13);
            var arl_14 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_14BlackForestArmory.prefab");
            SetLootChestPiece(arl_14);
            var arl_21 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_21SwampBasic.prefab");
            SetLootChestPiece(arl_21);
            var arl_22 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_22SwampAdv.prefab");
            SetLootChestPiece(arl_22);
            var arl_23 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_23SwampArmory.prefab");
            SetLootChestPiece(arl_23);
            var arl_31 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_31MountainsBasic.prefab");
            SetLootChestPiece(arl_31);
            var arl_32 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_32MountainsArmory.prefab");
            SetLootChestPiece(arl_32);
            var arl_41 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_41PlainsBasic.prefab");
            SetLootChestPiece(arl_41);
            var arl_42 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_42PlainsAdv.prefab");
            SetLootChestPiece(arl_42);
            var arl_43 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_43PlainsTreasure.prefab");
            SetLootChestPiece(arl_43);
            var arl_44 = new PieceManager.BuildPiece(RaikoneerLocations.EmbeddedResourceBundle, "arl_44PlainsArmory.prefab");
            SetLootChestPiece(arl_44);
            donePieces = true;
        }

        private static void SetLootChestPiece(BuildPiece piece)
        {
            piece.Name.English("Chest");
            piece.RequiredItems.Add("Wood", 10, false);
            piece.Tool.Tools.Clear();
            piece.RecipeIsActive = PluginConfig.LootChests;
        }

        private static void LoadLocations()
        {
            SetupLocation("arl_foresthold", new()
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
            });

            SetupLocation("arl_foresthold_deserted", new()
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
            });

            SetupLocation("arl_foresthold_remnant", new()
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
            });

            SetupLocation("arl_foresthold_ruins", new()
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
            });

            SetupLocation("arl_instairtower", new()
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
            });

            SetupLocation("arl_instairtower_damaged", new()
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
            });

            SetupLocation("arl_instairtower_rebuilt", new()
            {
                Biome = Heightmap.Biome.Plains,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)15, (float)100),
                SpawnDistance = new Range(3500, 5000),
                MinimumDistanceFromGroup = 300,
                GroupName = "arl_instairtower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random
            });

            SetupLocation("arl_instairtower_remnant", new()
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
            });

            SetupLocation("arl_instairtower_reruin", new()
            {
                Biome = Heightmap.Biome.Plains,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 15,
                Prioritize = false,
                SpawnAltitude = new Range((float)15, (float)100),
                SpawnDistance = new Range(4000, 6000),
                MinimumDistanceFromGroup = 300,
                GroupName = "arl_instairtower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random
            });

            SetupLocation("arl_instairtower_ruin", new()
            {
                Biome = Heightmap.Biome.BlackForest,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 15,
                Prioritize = false,
                SpawnAltitude = new Range((float)15, (float)100),
                SpawnDistance = new Range(2500, 5000),
                MinimumDistanceFromGroup = 300,
                GroupName = "arl_instairtower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                ForestThreshold = new Range(0,1)
            });

            SetupLocation("arl_jarlsmanshouse", new()
            {
                Biome = Heightmap.Biome.Meadows,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 8,
                Prioritize = false,
                SpawnAltitude = new Range((float)20, (float)60),
                SpawnDistance = new Range(2000, 5000),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_jarlsmanshouse",
                HeightDelta = new Range(0, 5),
                Rotation = Rotation.Random,
                ForestThreshold = new Range(1, 5)
            });

            SetupLocation("arl_jarlsmanshouse_remnant", new()
            {
                Biome = Heightmap.Biome.BlackForest,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 8,
                Prioritize = false,
                SpawnAltitude = new Range((float)20, (float)60),
                SpawnDistance = new Range(2000, 7000),
                MinimumDistanceFromGroup = 300,
                GroupName = "arl_jarlsmanshouse",
                HeightDelta = new Range(0, 5),
                Rotation = Rotation.Random,
                ForestThreshold = new Range(1, 5)
            });

            SetupLocation("arl_jarlsmanshouse_ruin", new()
            {
                Biome = Heightmap.Biome.Meadows,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 14,
                Prioritize = false,
                SpawnAltitude = new Range((float)20, (float)60),
                SpawnDistance = new Range(2000, 7000),
                MinimumDistanceFromGroup = 300,
                GroupName = "arl_jarlsmanshouse",
                HeightDelta = new Range(0, 5),
                Rotation = Rotation.Random,
                ForestThreshold = new Range(1, 5)
            });

            SetupLocation("arl_outpostcabin", new()
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
                ForestThreshold = new Range(0, 5)
            });

            SetupLocation("arl_outpostcabin_ruin", new()
            {
                Biome = Heightmap.Biome.Mountain,
                SpawnArea = Heightmap.BiomeArea.Edge,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)50, (float)100),
                SpawnDistance = new Range(1000, 4500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_outpostcabin",
                HeightDelta = new Range(0, 5),
                Rotation = Rotation.Random,
                ForestThreshold = new Range(0, 5)
            });

            SetupLocation("arl_outposttower", new()
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
                //ForestThreshold = new Range(0, 1)
            });

            SetupLocation("arl_outposttower_burnt", new()
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
                //ForestThreshold = new Range(0, 1)
            });

            SetupLocation("arl_outposttower_ruin", new()
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
                //ForestThreshold = new Range(0, 1)
            });

            SetupLocation("arl_outposttower_remnant", new()
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
                //ForestThreshold = new Range(0, 1)
            });

            SetupLocation("arl_pillartower", new()
            {
                Biome = Heightmap.Biome.Plains,
                SpawnArea = Heightmap.BiomeArea.Edge,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)20, (float)100),
                SpawnDistance = new Range(500, 5500),
                MinimumDistanceFromGroup = 400,
                GroupName = "arl_pillartower",
                HeightDelta = new Range(0, 3),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(0, 1)
            });

            SetupLocation("arl_pillartower_remnant", new()
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
                //ForestThreshold = new Range(0, 1)
            });

            SetupLocation("arl_pillartower_ruin", new() 
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
                //ForestThreshold = new Range(0, 1)
            });


            SetupLocation("arl_smallonghouse", new()
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
                //ForestThreshold = new Range(0, 1)
            });

            SetupLocation("arl_swamptower", new()
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
                //ForestThreshold = new Range(0, 1)
            });

            SetupLocation("arl_swamptower_remnant", new() {
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
                //ForestThreshold = new Range(0, 1)
            });

            SetupLocation("arl_swamptower_ruin", new()
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
                //ForestThreshold = new Range(0, 1)
            });

            SetupLocation("arl_traphouseplain", new LocationConfiguration
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
                //ForestThreshold = new Range(0, 1)
            });

            SetupLocation("arl_traphouseplain_ruin", new LocationConfiguration
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
                //ForestThreshold = new Range(0, 1)
            });

            SetupLocation("arl_traphouseplain_remnant", new LocationConfiguration
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
                //ForestThreshold = new Range(0, 1)
            });

            SetupLocation("arl_twotwohouse", new LocationConfiguration
            {
                Biome = Heightmap.Biome.Mountain,
                SpawnArea = Heightmap.BiomeArea.Edge,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)50, (float)100),
                SpawnDistance = new Range(1000, 3500),
                MinimumDistanceFromGroup = 200,
                GroupName = "arl_twotwohouse",
                HeightDelta = new Range(0, 5),
                Rotation = Rotation.Random,
                ForestThreshold = new Range(0, 1)
            });

            SetupLocation("arl_twotwohouse_remnant", new LocationConfiguration
            {
                Biome = Heightmap.Biome.Meadows,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 20,
                Prioritize = false,
                SpawnAltitude = new Range((float)15, (float)100),
                SpawnDistance = new Range(1000, 3500),
                MinimumDistanceFromGroup = 300,
                GroupName = "arl_twotwohouse",
                HeightDelta = new Range(0, 4),
                Rotation = Rotation.Random,
                ForestThreshold = new Range(0, 3)
            });

            SetupLocation("arl_twotwohouse_ruin", new LocationConfiguration
            { 
                Biome = Heightmap.Biome.Meadows,
                SpawnArea = Heightmap.BiomeArea.Everything,
                Count = 20,
                Prioritize = false,
                SpawnAltitude = new Range((float)20, (float)100),
                SpawnDistance = new Range(1000, 3500),
                MinimumDistanceFromGroup = 300,
                GroupName = "arl_twotwohouse_ruins",
                HeightDelta = new Range(0, 5),
                Rotation = Rotation.Random,
                //ForestThreshold = new Range(1, 1)
            });

            SetupLocation("arl_twotwohouse_stormed", new LocationConfiguration()
            {
                Biome = Heightmap.Biome.Mountain,
                SpawnArea = Heightmap.BiomeArea.Edge,
                Count = 10,
                Prioritize = false,
                SpawnAltitude = new Range((float)20, (float)100),
                SpawnDistance = new Range(1000, 4000),
                MinimumDistanceFromGroup = 200,
                GroupName = "arl_twotwohouse",
                HeightDelta = new Range(0, 5),
                Rotation = Rotation.Random,
                ForestThreshold = new Range(0, 2)
            });

            RaikoneerLocations.PluginLogger.LogMessage("ARL ran location loaders.");
            donePieces = true;
        }

        private static void SetupLocation(string locationName, LocationConfiguration locationConfiguration)
        {
            var prefab = RaikoneerLocations.EmbeddedResourceBundle.LoadAsset<GameObject>($"assets/{locationName}.prefab");
            PluginConfig.LocationPrefabs[locationName] = prefab.GetComponent<global::Location>();
            _ = new LocationManager.Location(prefab)
            {
                Biome = locationConfiguration.Biome,
                SpawnArea = locationConfiguration.SpawnArea,
                Count = locationConfiguration.Count,
                Prioritize = locationConfiguration.Prioritize,
                SpawnAltitude = locationConfiguration.SpawnAltitude,
                SpawnDistance = locationConfiguration.SpawnDistance,
                MinimumDistanceFromGroup = locationConfiguration.MinimumDistanceFromGroup,
                GroupName = locationConfiguration.GroupName,
                HeightDelta = locationConfiguration.HeightDelta,
                Rotation = locationConfiguration.Rotation,
                //ForestThreshold = new Range(0, 1)
            };
        }

        public static void FixSpawners()
        {

            UpdateSpawnerRefs("foresthold", PluginConfig.SpawnerMap["arl_foresthold"]);
            UpdateSpawnerRefs("foresthold_deserted", PluginConfig.SpawnerMap["arl_foresthold_deserted"]);
            UpdateSpawnerRefs("foresthold_remnant", PluginConfig.SpawnerMap["arl_foresthold_remnant"]);
            UpdateSpawnerRefs("foresthold_ruins", PluginConfig.SpawnerMap["arl_foresthold_ruins"]);
            UpdateSpawnerRefs("instairtower", PluginConfig.SpawnerMap["arl_instairtower"]);
            UpdateSpawnerRefs("instairtower_damaged", PluginConfig.SpawnerMap["arl_instairtower_damaged"]);
            UpdateSpawnerRefs("instairtower_rebuilt", PluginConfig.SpawnerMap["arl_instairtower_rebuilt"]);
            UpdateSpawnerRefs("instairtower_remnant", PluginConfig.SpawnerMap["arl_instairtower_remnant"]);
            UpdateSpawnerRefs("instairtower_reruin", PluginConfig.SpawnerMap["arl_instairtower_reruin"]);
            UpdateSpawnerRefs("instairtower_ruin", PluginConfig.SpawnerMap["arl_instairtower_ruin"]);
            UpdateSpawnerRefs("jarlsmanshouse", PluginConfig.SpawnerMap["arl_jarlsmanshouse"]);
            UpdateSpawnerRefs("jarlsmanshouse_remnant", PluginConfig.SpawnerMap["arl_jarlsmanshouse_remnant"]);
            UpdateSpawnerRefs("outpostcabin", PluginConfig.SpawnerMap["arl_outpostcabin"]);
            UpdateSpawnerRefs("outpostcabin_ruin", PluginConfig.SpawnerMap["arl_outpostcabin_ruin"]);
            UpdateSpawnerRefs("outposttower", PluginConfig.SpawnerMap["arl_outposttower"]);
            UpdateSpawnerRefs("outposttower_burnt", PluginConfig.SpawnerMap["arl_outposttower_burnt"]);
            UpdateSpawnerRefs("outposttower_ruin", PluginConfig.SpawnerMap["arl_outposttower_ruin"]);
            UpdateSpawnerRefs("outposttower_remnant", PluginConfig.SpawnerMap["arl_outposttower_remnant"]);
            UpdateSpawnerRefs("pillartower", PluginConfig.SpawnerMap["arl_pillartower"]);
            UpdateSpawnerRefs("pillartower_remnant", PluginConfig.SpawnerMap["arl_pillartower_remnant"]);
            UpdateSpawnerRefs("pillartower_ruin", PluginConfig.SpawnerMap["arl_pillartower_ruin"]);
            UpdateSpawnerRefs("smallonghouse", PluginConfig.SpawnerMap["arl_smallonghouse"]);
            UpdateSpawnerRefs("swamptower", PluginConfig.SpawnerMap["arl_swamptower"]);
            UpdateSpawnerRefs("swamptower_remnant", PluginConfig.SpawnerMap["arl_swamptower_remnant"]);
            UpdateSpawnerRefs("swamptower_ruin", PluginConfig.SpawnerMap["arl_swamptower_ruin"]);
            UpdateSpawnerRefs("traphouseplain", PluginConfig.SpawnerMap["arl_traphouseplain"]);
            UpdateSpawnerRefs("traphouseplain_remnant", PluginConfig.SpawnerMap["arl_traphouseplain_remnant"]);
            UpdateSpawnerRefs("traphouseplain_ruin", PluginConfig.SpawnerMap["arl_traphouseplain_ruin"]);
            UpdateSpawnerRefs("twotwohouse", PluginConfig.SpawnerMap["arl_twotwohouse"]);
            UpdateSpawnerRefs("twotwohouse_remnant", PluginConfig.SpawnerMap["arl_twotwohouse_remnant"]);
            UpdateSpawnerRefs("twotwohouse_ruin", PluginConfig.SpawnerMap["arl_twotwohouse_ruin"]);
            UpdateSpawnerRefs("twotwohouse_stormed", PluginConfig.SpawnerMap["arl_twotwohouse_stormed"]);

        }

        private static void UpdateSpawnerRefs(string name, Dictionary<string, CreatureSpawnerNameConfig> spawnerDefinitions)
        {
            RaikoneerLocations.PluginLogger.LogDebug($"Setting spawns for {name}");
            string fullName = $"arl_{name}";

            var locationRoot = PluginConfig.LocationPrefabs[fullName];

            var spawnersNode = locationRoot.transform.Find("Spawners");

            foreach (var targetSpawner in spawnerDefinitions.Keys)
            {
                var targetSpawnerT = spawnersNode.Find($"{name}_{targetSpawner}");

                string usingName = spawnerDefinitions[targetSpawner].TestConfigValue();

                CreatureSpawner creatureSpawner = targetSpawnerT.gameObject.GetComponent<CreatureSpawner>();

                GameObject updatedCreatureRef = zNet.GetPrefab(usingName);

                RaikoneerLocations.PluginLogger.LogInfo($"{(creatureSpawner == null ? "No spawnercomponent found" : "Got spawnercomponent")} and using {usingName}");

                creatureSpawner.m_creaturePrefab = updatedCreatureRef;
            }
        }
    }

    internal class LocationConfiguration
    {
        public Heightmap.Biome Biome = Heightmap.Biome.Meadows;
        public Heightmap.BiomeArea SpawnArea = Heightmap.BiomeArea.Everything;
        public int Count = 1;
        public bool Prioritize = false;
        public Range SpawnAltitude = new Range((float)15, (float)100);
        public Range SpawnDistance = new Range(0, 7500);
        public int MinimumDistanceFromGroup = 250;
        public string GroupName = "wilderness";
        public Range HeightDelta = new Range(0, 3);
        public Rotation Rotation = Rotation.Random;
        public Range ForestThreshold = new Range(0, 1);
    };
}
