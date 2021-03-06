using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Text_torisetu : MonoBehaviour
{
    //初めの取扱説明書の部分関係のスクリプト


    [SerializeField]
    string[] sentences;

    [SerializeField]
    TextMeshProUGUI torisetu_text;

    [SerializeField]
    GameObject tojirubutton;

    [SerializeField]
    GameObject nextbutton;

    [SerializeField]
    GameObject returnbutton;

    int textcount = 0;

    [SerializeField]
    GameObject image_torisetu;

    void Start()
    {
        tojirubutton.SetActive(false);
        returnbutton.SetActive(false);
        image_torisetu.SetActive(false);
    }

    void Update()
    {
        if(textcount == 0)
        {
            torisetu_text.text = "まずはじめに…\n\nここでは自分オリジナルの部屋を作ることを目的としています。\n家具を好きな位置に配置して楽しんでください！";
            tojirubutton.SetActive(false);
            returnbutton.SetActive(false);
            image_torisetu.SetActive(false);
        }
        else if (textcount == 1)
        {
            torisetu_text.text = "〜コントローラー〜\n\n左トリガー…メニューを開く\n左Yボタン…家具を回転させる\n左Xボタン…家具を設置する\n右トリガー…選択中の家具を削除\n右Bボタン…ドラッグ＆ドロップで家具を移動\n右Aボタン…メニューのボタンを押す";
            returnbutton.SetActive(true);
            image_torisetu.SetActive(true);
        }
        if (textcount == 2)
        {
            torisetu_text.text = "操作説明は以上となります。\n\nメニューの設定を開くとまたいつでも操作説明を見ることができます。\n\n設定では朝昼夜を選べたりBGMを変えたりもできるので慣れてきたら試してみましょう。";
            tojirubutton.SetActive(true);
            nextbutton.SetActive(false);
            image_torisetu.SetActive(false);
        }
        else
        {
            nextbutton.SetActive(true);
            tojirubutton.SetActive(false);
        };

    }

    public void pluscount()
    {
        if (textcount < 2)
        {
            textcount += 1;
        }
    }

    public void mainasucount()
    {
        if (textcount > 0)
        {
            textcount -= 1;
        }
    }

}
