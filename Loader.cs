using BepInEx.Configuration;
using RaikoneerLocations.PrefabIniters;

namespace RaikoneerLocations.Loaders
{
    internal static class StuffLoader
    {
        internal static void Load(ConfigFile config)
        {
            LoadStuff(config);
        }

        internal static void LoadMonsters(ConfigFile config)
        {
          NoArcherSkeleton(config);
        }
    }
}
