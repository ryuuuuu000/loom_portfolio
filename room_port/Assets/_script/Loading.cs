using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Loading : MonoBehaviour
{
    //　非同期動作で使用するAsyncOperation
    private AsyncOperation async;

    //　シーンロード中に表示するUI背景
    [SerializeField]
    private GameObject loadUI;

    //ローディング中のくるくるUI
    [SerializeField]
    private GameObject loadimage;

    //
    private const float DURATION = 1f;

    //　フェードインのおおよその秒数
    [SerializeField]
    private float fadeInTime;
    //　背景Image
    private Image image;

    private void Start()
    {
        image = loadUI.GetComponent<Image>();
        //　コルーチンで使用する待ち時間を計測
        fadeInTime = 1f * fadeInTime / 10f;
    }


    public void NextScene()
    {
        //　ロード画面UIをアクティブにする
        loadUI.SetActive(true);
        //小オブジェクト達をここに入れる
        Image[] circles = loadimage.GetComponentsInChildren<Image>();
        for (var i = 0; i < circles.Length; i++)
        {
            var angle = -2 * Mathf.PI * i / circles.Length;
            circles[i].rectTransform.anchoredPosition = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * 50f;
            circles[i].DOFade(0f, DURATION).SetLoops(-1, LoopType.Yoyo).SetDelay(DURATION * i / circles.Length);
        }
        //　コルーチンを開始
        StartCoroutine("LoadData");
    }

    IEnumerator LoadData()
	{
        // シーンの読み込みをする
        async = SceneManager.LoadSceneAsync("Main");

        //　読み込みが終わるまでローディングの回転
        while (!async.isDone)
		{

            yield return null;

        }


    }

}
