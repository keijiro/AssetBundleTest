using UnityEngine;
using UnityEditor;
using System.Collections;

public class AssetBundleTool
{
    [MenuItem("AssetBundle/Set Asset Bundle Names")]
    static void SetAssetBundleNames()
    {
        for (var i = 0; i < 200; i++)
        {
            var name = "Bundle" + i.ToString("000");
            SetAssetBundleNameOfImage(i * 2, name);
            SetAssetBundleNameOfImage(i * 2 + 1, name);
        }
    }

    static void SetAssetBundleNameOfImage(int index, string name)
    {
        var assetPath = "Assets/Images/Image" + index.ToString("000") + ".png";
        var importer = AssetImporter.GetAtPath(assetPath);
        importer.assetBundleName = name;
    }

    [MenuItem("AssetBundle/Build All Asset Bundles")]
    static void BuildAllAssetBundles()
    {
#if UNITY_ANDROID
        BuildPipeline.BuildAssetBundles("AssetBundles/Android", BuildAssetBundleOptions.None, BuildTarget.Android);
#elif UNITY_IOS
        BuildPipeline.BuildAssetBundles("AssetBundles/iOS", BuildAssetBundleOptions.None, BuildTarget.iOS);
#else
        Debug.Log("This platform is not supported.");
#endif
    }
}
