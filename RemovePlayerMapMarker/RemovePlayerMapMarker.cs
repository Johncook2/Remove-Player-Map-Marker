using UnityEngine;
using Winch.Core;
using HarmonyLib;

namespace RemovePlayerMapMarker.Patches
{

	[HarmonyPatch(typeof(MapWindow), "GetPlayerPositionAsMapPosition")]
	public static class MapWindow_GetPlayerPositionAsMapPosition_Patch
	{
		static void Postfix( ref Vector2 __result)
		{
			__result.Set(0,0);
		}
	}

	[HarmonyPatch(typeof(MapWindow), "Show")]
	public static class MapWindow_Show_Patch
	{
		static void Postfix(MapWindow __instance)
		{
			Sprite blankSprite;
			blankSprite = Resources.LoadAll<Sprite>("removeplayermapmarker.empty");
			__instance.boatImage.sprite = blankSprite;
		}
	}
}

