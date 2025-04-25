using HarmonyLib;

namespace CustomAircraftTemplateAIRCRAFTNAME.AircraftScripts.Patches.Base.CampaignStuff;

[HarmonyPatch(typeof(VTResources), "LoadExternalVehicle")]
public class OkuPatch
{
	private static bool Prefix()
	{
		VTResources.canLoadExternalVehicles = true;
		return true;
	}
}
