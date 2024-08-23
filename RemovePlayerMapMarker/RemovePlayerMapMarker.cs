using UnityEngine;
using Winch.Core;
using Harmonylib;

namespace RemovePlayerMapMarker
{

	[HarmonyPatch(typeof(MapWindow), "GetPlayerPositionAsMapPosition")]
	public static class MapWindow_GetPlayerPositionAsMapPosition_Patch
	{
		static void Postfix( ref Vector2 __result)
		{
			__result.Set(0,0);
		}
	}
}

