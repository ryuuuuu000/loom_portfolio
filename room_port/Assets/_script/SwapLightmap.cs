using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapLightmap : MonoBehaviour
{
    // ライトマップファイルと法線ライトマップを格納する配列
    [SerializeField] Texture2D[] lightMap;
    // 法線ライトマップを格納する配列
    [SerializeField] Texture2D[] dir;
    // ライトプローブファイルを格納する配列
    [SerializeField] LightProbes[] lightProbe;
    // ReflectionProbeファイルを格納する配列
    [SerializeField] Cubemap[] reflectionProbe;
    // リフレクションプローブを格納する変数
    [SerializeField] ReflectionProbe probeComponent;
    [SerializeField] ReflectionProbe probeComponent2;
    // 明るい照明のライトマップデータ
    LightmapData[] brightDatas;
    // 夕方照明のライトマップデータ
    LightmapData[] SunsetDatas;
    //　夜照明のrアイトマップでデータ
    LightmapData[] darkDatas;

    //ディレクショナルライトの色関係
    [SerializeField]
    GameObject Dlight;
    Light _light;

    //スカイボックスを格納
    [SerializeField]
    Material[] sky;

    //ディレクショナルライト
    [SerializeField]
    GameObject pointlight;
    bool pointlightswich = false;

    [SerializeField]
    GameObject soundamane;

    private void Awake()
    {
        _light = Dlight.GetComponent<Light>();

        brightDatas = new LightmapData[1]; // 空のLightmapData型の配列を作る。
        brightDatas[0] = new LightmapData();// 1つめの要素にLightmapData型のインスタンスを作成する
        brightDatas[0].lightmapColor = lightMap[0];
        brightDatas[0].lightmapDir = dir[0];

        SunsetDatas = new LightmapData[1];
        SunsetDatas[0] = new LightmapData();
        SunsetDatas[0].lightmapColor = lightMap[1];
        SunsetDatas[0].lightmapDir = dir[1];

        darkDatas = new LightmapData[1];
        darkDatas[0] = new LightmapData();
        darkDatas[0].lightmapColor = lightMap[2];
        darkDatas[0].lightmapDir = dir[2];
    }


    // ゲームスタート時の処理
    void Start()
    {
        BrightLightmap();
    }


    public void Swapmorninglight()
    {
        BrightLightmap();
    }

    public void Swapsunsetlight()
    {
        SunsetLightmap();
    }

    public void SwapDarklight()
    {
        DarkLightmap();
    }



    // 朝バージョンの照明のライトマップ設定を現在のシーンに適用する処理
    void BrightLightmap()
    {
        //lightmapsは配列
        // 明るい照明のライトマップファイルを現在のライトマップ設定に適用
        LightmapSettings.lightmaps = brightDatas;

        // 明るい照明のリフレクションプローブファイルを現在のリフレクションプローブに適用
        probeComponent.customBakedTexture = reflectionProbe[0];
        probeComponent2.customBakedTexture = reflectionProbe[1];

        RenderSettings.skybox = sky[0];

        soundamane.GetComponent<soundscript>().BGM3Play();

        _light.color = new Color(255f / 255f, 255f / 255f, 255f / 255f, 1.0f);
    }

    // 夕方バージョンの照明のライトマップデータを現在のシーンに適用する処理
    void SunsetLightmap()
    {
        LightmapSettings.lightmaps = SunsetDatas;

        probeComponent.customBakedTexture = reflectionProbe[2];
        probeComponent2.customBakedTexture = reflectionProbe[3];

        soundamane.GetComponent<soundscript>().BGM4Play();

        RenderSettings.skybox = sky[1];

        _light.color = new Color(255f / 255f, 185f / 255f, 125f / 255f, 1.0f);
    }

    //夜バージョンの照明のライトマップデータを現在のシーンに適応する処理
    void DarkLightmap()
    {
        LightmapSettings.lightmaps = darkDatas;

        probeComponent.customBakedTexture = reflectionProbe[4];
        probeComponent2.customBakedTexture = reflectionProbe[5];

        RenderSettings.skybox = sky[2];

        _light.color = new Color(100f / 255f, 120f / 255f, 180f / 255f, 1.0f);

        soundamane.GetComponent<soundscript>().BGM5Play();

    }

}
