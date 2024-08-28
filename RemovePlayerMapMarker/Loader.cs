using HarmonyLib;
using System.Reflection;

namespace Remove-Player-Map-Marker
{
    public class Loader
    {
        /// <summary>
        /// This method is run by Winch to initialize your mod
        /// </summary>
        public static void Initialize()
        {
            new Harmony("com.Johncook.RemovePlayerMapMarker").PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
