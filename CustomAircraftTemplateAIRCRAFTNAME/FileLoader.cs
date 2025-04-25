using System;
using UnityEngine;

namespace CustomAircraftTemplateAIRCRAFTNAME;

internal static class FileLoader
{
	public static AssetBundle GetAssetBundleAsGameObject(string path, string name)
	{
		AssetBundle assetBundle = null;
		try
		{
			return AssetBundle.LoadFromFile(path);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static GameObject GetPrefabAsGameObject(AssetBundle bundleLoad, string name)
	{
		try
		{
			UnityEngine.Object @object = bundleLoad.LoadAsset(name, typeof(GameObject));
			return (GameObject)@object;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static Shader GetShader(AssetBundle bundleLoad, string name)
	{
		try
		{
			UnityEngine.Object @object = bundleLoad.LoadAsset(name, typeof(Shader));
			return (Shader)@object;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static Texture GetTexture(AssetBundle bundleLoad, string name)
	{
		try
		{
			UnityEngine.Object @object = bundleLoad.LoadAsset(name, typeof(Texture));
			return (Texture)@object;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static ScriptableObject GetPrefabAsScriptableObject(AssetBundle bundleLoad, string name)
	{
		try
		{
			UnityEngine.Object @object = bundleLoad.LoadAsset(name, typeof(ScriptableObject));
			return (ScriptableObject)@object;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static Campaign GetPrefabAsCampaigns(AssetBundle bundleLoad, string name)
	{
		try
		{
			UnityEngine.Object @object = bundleLoad.LoadAsset(name, typeof(Campaign));
			return (Campaign)@object;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static BuiltInCampaigns GetPrefabAsBICampaigns(AssetBundle bundleLoad, string name)
	{
		try
		{
			UnityEngine.Object @object = bundleLoad.LoadAsset(name, typeof(BuiltInCampaigns));
			return (BuiltInCampaigns)@object;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static PlayerVehicle GetPrefabAsPlayerVehicle(AssetBundle bundleLoad, string name)
	{
		try
		{
			UnityEngine.Object @object = bundleLoad.LoadAsset(name, typeof(PlayerVehicle));
			return (PlayerVehicle)@object;
		}
		catch (Exception)
		{
			return null;
		}
	}
}
