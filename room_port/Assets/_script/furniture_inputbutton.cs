using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonIven_menu : MonoBehaviour,IPointerDownHandler
{
    //主にメニューのパネルの表示非表示をするスクリプト
    //BGM変更するためのボタンの処理、設定パネルのボタンの処理など



    [SerializeField]
    GameObject laserpointerL;//左手を操作してるオブジェクト
    [SerializeField]
    GameObject kagupanel;//家具一覧のパネル
    [SerializeField]
    GameObject settingpanel;//設定ができるパネル
    [SerializeField]
    GameObject bgmsettingpanel;//bhmの変更ができるパネル
    [SerializeField]
    GameObject yesnopanel;//家具を全て撤去するときに、本当に撤去するか再度確認してくるパネル
    [SerializeField]
    GameObject torisetu;//操作説明のパネル
    [SerializeField]
    GameObject torisetu_trueorfalse;//操作説明を閉じるかどうか聞いてくるパネル
    [SerializeField]
    GameObject title_yesynopanel;//タイトルに戻るときに本当に戻るのか再度確認してくるパネル
    [SerializeField]
    GameObject BGMchange;//BGMを変えれるボタンがあるパネルへ移動
    [SerializeField]
    GameObject soundchangepanel;//BGMをボタンで変えるパネル
    [SerializeField]
    GameObject soundmanejer;//全てのサウンドをコントロールしてるマネージャー



    void Start()
    {
    }

    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(this.gameObject.name == "home_button")//家具オブジェクトの選択パネルを表示
        {
            bgmsettingpanel.SetActive(false);

            kagupanel.SetActive(true);
            settingpanel.SetActive(false);
            bgmsettingpanel.SetActive(false);
            soundchangepanel.SetActive(false);
        }
        if (this.gameObject.name == "setumeisyo_button")//説明書があるパネルを表示
        {
            torisetu.SetActive(true);
        }
        if (this.gameObject.name == "setting_button")//設定ができるパネルを表示
        {
            kagupanel.SetActive(false);
            settingpanel.SetActive(true);
            bgmsettingpanel.SetActive(false);
            soundchangepanel.SetActive(false);
        }


        //ゲームオブジェクトを全て削除するかどうかのパネル操作↓
        if (this.gameObject.name == "riset_button")//今あるゲームオブジェクトを全て削除するかどうか聞いてくるパネル
        {
            yesnopanel.SetActive(true);
        }
        if (this.gameObject.name == "Yes_Button")//はいのボタンを押したら現在あるゲームオブジェクトを全て削除
        {
            GameObject[] objs = GameObject.FindGameObjectsWithTag("cube");
            foreach (GameObject obj in objs)
            {
                Destroy(obj);
            }
        }
        if (this.gameObject.name == "No_Button")//いいえのボタンを押したらはいorいいえのパネルを閉じる
        {
            yesnopanel.SetActive(false);
        }
        if (this.gameObject.name == "Exit_Button")//閉じるのボタンを押したらはいorいいえのパネルを閉じる
        {
            yesnopanel.SetActive(false);
        }


        //操作説明を終了するかどうかのパネル↓
        if (this.gameObject.name == "batu_button")//
        {
            torisetu_trueorfalse.SetActive(true);
        }
        if (this.gameObject.name == "end_Button")//
        {
            torisetu_trueorfalse.SetActive(true);
        }
        if (this.gameObject.name == "yes_Button")//
        {
            torisetu_trueorfalse.SetActive(false);
            torisetu.SetActive(false);
        }
        if (this.gameObject.name == "no_Button")//
        {
            torisetu_trueorfalse.SetActive(false);
        }




        //タイトルへ戻るかどうかのパネル操作
        if (this.gameObject.name == "taitle_button")//タイトルに戻るか聞いてくるパネルを表示
        {
            title_yesynopanel.SetActive(true);
        }
        if (this.gameObject.name == "title_yes_Button")//タイトルへ戻るか聞いてくるパネルではいの場合はタイトルに戻る
        {
            SceneManager.LoadScene("Apartment");
        }
        if (this.gameObject.name == "title_no_Button")//タイトルへ戻るか聞いてくるパネルでいいえの場合タイトルに戻るかどうか聞くパネルを閉じる
        {
            title_yesynopanel.SetActive(false);
        }


        //サウンドマネージャーにアクセスしボタンに応じてBGMを変える
        if(this.gameObject.name == "bgm_button1")
        {
            soundmanejer.GetComponent<soundscript>().BGM1Play();
        }
        else if (this.gameObject.name == "bgm_button2")
        {
            soundmanejer.GetComponent<soundscript>().BGM2Play();
        }
        else if (this.gameObject.name == "bgm_button3")
        {
            soundmanejer.GetComponent<soundscript>().BGM3Play();
        }
        else if (this.gameObject.name == "bgm_button4")
        {
            soundmanejer.GetComponent<soundscript>().BGM4Play();
        }
        else if (this.gameObject.name == "bgm_button5")
        {
            soundmanejer.GetComponent<soundscript>().BGM5Play();
        }


        if(this.gameObject.name == "return_button")//設定画面の戻るボタンを押したらBGMを変える為のパネルを閉じて設定パネルを表示
        {
            soundchangepanel.SetActive(false);
            settingpanel.SetActive(true);
        }
        if(this.gameObject.name == "sound_button")//音声ボタンを押したらBGMを変えれるボタンがあるパネルに移動
        {
            settingpanel.SetActive(false);
            soundchangepanel.SetActive(true);
        }
    }
}
