using HarmonyLib;

namespace CustomAircraftTemplateAIRCRAFTNAME.AircraftScripts.Patches.Base;

[HarmonyPatch(typeof(PilotSelectUI), "StartSelectedPilotButton")]
public class StartPilot
{
	private static bool Prefix(PilotSelectUI __instance)
	{
		__instance.vehicles = PilotSaveManager.GetVehicleList();
		return true;
	}
}
