using UnityEngine;
using Winch.Core;
using HarmonyLib;

namespace RemovePlayerMapMarker
{

	[HarmonyPatch(typeof(MapWindow), "GetPlayerPositionAsMapPosition")]
	public static class MapWindow_GetPlayerPositionAsMapPosition_Patch
	{
		static void Postfix( ref __result)
		{
			__result.Set(0,0);
		}
	}
}

