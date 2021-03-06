using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Input_Text_enter : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler
{
    //レイが今なんのボタンの上に乗っているか監視しているスクリプト
    //ボタンの名前によってテキストを変更している

    GameObject textmanejer;



    void Start()
    {
        textmanejer = GameObject.Find("Text_manejer");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //ボタンの名前によって、表示する家具オブジェクトの名前を変更
        if (this.gameObject.name == "ac01_Button")
        {
            textmanejer.GetComponent<Text_names>().Text0();
        }
        if (this.gameObject.name == "basket01_1_Button")
        {
            textmanejer.GetComponent<Text_names>().Text1();
        }
        if (this.gameObject.name == "basket01_2_Button")
        {
            textmanejer.GetComponent<Text_names>().Text2();

        }
        if (this.gameObject.name == "bed01_Button")
        {
            textmanejer.GetComponent<Text_names>().Text3();

        }
        if (this.gameObject.name == "pillow02_1_Button")
        {
            textmanejer.GetComponent<Text_names>().Text4();

        }
        if (this.gameObject.name == "pillow3_1_Button")
        {
            textmanejer.GetComponent<Text_names>().Text5();

        }
        if (this.gameObject.name == "cabinet01_1_Button")
        {
            textmanejer.GetComponent<Text_names>().Text6();

        }
        if (this.gameObject.name == "cabinet01_2_Button")
        {
            textmanejer.GetComponent<Text_names>().Text7();

        }
        if (this.gameObject.name == "cabinet01_3_Button")
        {
            textmanejer.GetComponent<Text_names>().Text8();

        }
        if (this.gameObject.name == "cabinet02_1_Button")
        {
            textmanejer.GetComponent<Text_names>().Text9();

        }
        if (this.gameObject.name == "cabinet02_2_Button")
        {
            textmanejer.GetComponent<Text_names>().Text10();

        }
        if (this.gameObject.name == "cabinet02_3_Button")
        {
            textmanejer.GetComponent<Text_names>().Text11();

        }
        if (this.gameObject.name == "chair01_1_Button")
        {
            textmanejer.GetComponent<Text_names>().Text12();

        }
        if (this.gameObject.name == "chair01_2_Button")
        {
            textmanejer.GetComponent<Text_names>().Text13();

        }
        if (this.gameObject.name == "chair01_3_Button")
        {
            textmanejer.GetComponent<Text_names>().Text14();

        }
        if (this.gameObject.name == "chair01_4_Button")
        {
            textmanejer.GetComponent<Text_names>().Text15();

        }
        if (this.gameObject.name == "chair02_1_Button")
        {
            textmanejer.GetComponent<Text_names>().Text16();

        }
        if (this.gameObject.name == "chair02_2_Button")
        {
            textmanejer.GetComponent<Text_names>().Text17();

        }
        if (this.gameObject.name == "clock01_1_Button")
        {
            textmanejer.GetComponent<Text_names>().Text18();

        }
        if (this.gameObject.name == "clock01_2_Button")
        {
            textmanejer.GetComponent<Text_names>().Text19();

        }
        if (this.gameObject.name == "lamp03_on_Button")
        {
            textmanejer.GetComponent<Text_names>().Text20();

        }
        if (this.gameObject.name == "lamp05_on_Button")
        {
            textmanejer.GetComponent<Text_names>().Text21();

        }
        if (this.gameObject.name == "mirror03_Button")
        {
            textmanejer.GetComponent<Text_names>().Text22();

        }
        if (this.gameObject.name == "plant01_2_Button")
        {
            textmanejer.GetComponent<Text_names>().Text23();

        }
        if (this.gameObject.name == "plant02_2_Button")
        {
            textmanejer.GetComponent<Text_names>().Text24();

        }
        if (this.gameObject.name == "rug01_1_Button")
        {
            textmanejer.GetComponent<Text_names>().Text25();

        }
        if (this.gameObject.name == "rug01_2_Button")
        {
            textmanejer.GetComponent<Text_names>().Text26();

        }
        if (this.gameObject.name == "rug01_3_Button")
        {
            textmanejer.GetComponent<Text_names>().Text27();

        }
        if (this.gameObject.name == "shelf01_Button")
        {
            textmanejer.GetComponent<Text_names>().Text28();

        }
        if (this.gameObject.name == "shelf02_Button")
        {
            textmanejer.GetComponent<Text_names>().Text29();

        }
        if (this.gameObject.name == "sideboard01_1_Button")
        {
            textmanejer.GetComponent<Text_names>().Text30();

        }
        if (this.gameObject.name == "sideboard01_2_Button")
        {
            textmanejer.GetComponent<Text_names>().Text31();

        }
        if (this.gameObject.name == "sideboard01_3_Button")
        {
            textmanejer.GetComponent<Text_names>().Text32();

        }
        if (this.gameObject.name == "table01_1_Button")
        {
            textmanejer.GetComponent<Text_names>().Text33();

        }
        if (this.gameObject.name == "table01_2_Button")
        {
            textmanejer.GetComponent<Text_names>().Text34();

        }
        if (this.gameObject.name == "table02_1_Button")
        {
            textmanejer.GetComponent<Text_names>().Text35();

        }
        if (this.gameObject.name == "table02_2_Button")
        {
            textmanejer.GetComponent<Text_names>().Text36();

        }
        if (this.gameObject.name == "table02_3_Button")
        {
            textmanejer.GetComponent<Text_names>().Text37();

        }
        if (this.gameObject.name == "table03_1_Button")
        {
            textmanejer.GetComponent<Text_names>().Text38();

        }
        if (this.gameObject.name == "table03_2_Button")
        {
            textmanejer.GetComponent<Text_names>().Text39();

        }

        if (this.gameObject.name == "tv01_Button")
        {
            textmanejer.GetComponent<Text_names>().Text40();

        }
        if (this.gameObject.name == "outlet01_Button")
        {
            textmanejer.GetComponent<Text_names>().Text41();

        }
        if (this.gameObject.name == "fridge01_1_Button")
        {
            textmanejer.GetComponent<Text_names>().Text42();

        }
        if (this.gameObject.name == "microwave01_Button")
        {
            textmanejer.GetComponent<Text_names>().Text43();

        }


        //メニュー左
        if (this.gameObject.name == "home_button")
        {
            textmanejer.GetComponent<Text_names>().Text44();

        }
        if (this.gameObject.name == "cancel_button")
        {
            textmanejer.GetComponent<Text_names>().Text45();

        }
        if (this.gameObject.name == "setting_button")
        {
            textmanejer.GetComponent<Text_names>().Text46();
        }


        //BGMボタン
        if (this.gameObject.name == "bgm_button1")
        {
            textmanejer.GetComponent<Text_names>().Text47();
        }
        if (this.gameObject.name == "bgm_button2")
        {
            textmanejer.GetComponent<Text_names>().Text48();
        }
        if (this.gameObject.name == "bgm_button3")
        {
            textmanejer.GetComponent<Text_names>().Text49();
        }
        if (this.gameObject.name == "bgm_button4")
        {
            textmanejer.GetComponent<Text_names>().Text50();
        }
        if (this.gameObject.name == "bgm_button5")
        {
            textmanejer.GetComponent<Text_names>().Text51();
        }
        if (this.gameObject.name == "return_button")//BGM設定画面の戻るボタンを押したらBGMを変える為のパネルを閉じて設定パネルを表示
        {
            textmanejer.GetComponent<Text_names>().Text52();
        }

        //設定画面のアウトライン操作（レイがボタンに乗ったら処理される）
        if (this.gameObject.name == "sound_button")//BGMを変更する
        {
            textmanejer.GetComponent<Text_names>().Text53();
        }
        if (this.gameObject.name == "setumeisyo_button")//説明書を開く
        {
            textmanejer.GetComponent<Text_names>().Text54();
        }
        if (this.gameObject.name == "taitle_button")//タイトルへ戻る
        {
            textmanejer.GetComponent<Text_names>().Text55();
        }
        if (this.gameObject.name == "riset_button")//今あるゲームオブジェクトを削除
        {
            textmanejer.GetComponent<Text_names>().Text56();
        }




        if (this.gameObject.name == "Yes_Button")//はいのボタンを押したら現在あるゲームオブジェクトを全て削除
        {
            textmanejer.GetComponent<Text_names>().Text57();

        }
        if (this.gameObject.name == "No_Button")//いいえのボタンを押したらはいorいいえのパネルを閉じる
        {
            textmanejer.GetComponent<Text_names>().Text58();
        }
        if (this.gameObject.name == "Exit_Button")//閉じるのボタンを押したらはいorいいえのパネルを閉じる
        {
            textmanejer.GetComponent<Text_names>().Text59();
        }
        if (this.gameObject.name == "title_yes_Button")//タイトルへ戻るか聞いてくるパネルではいの場合はタイトルに戻る
        {
            textmanejer.GetComponent<Text_names>().Text60();
        }
        if (this.gameObject.name == "title_no_Button")//タイトルへ戻るか聞いてくるパネルでいいえの場合タイトルに戻るかどうか聞くパネルを閉じる
        {
            textmanejer.GetComponent<Text_names>().Text61();
        }
        if(this.gameObject.name == "lightswich_button")//ライトのテキスト
        {
            textmanejer.GetComponent<Text_names>().Text62();
        }
        if (this.gameObject.name == "morning_button")//朝のライトマップ
        {
            textmanejer.GetComponent<Text_names>().Text63();
        }
        if (this.gameObject.name == "sunset_button")//朝のライトマップ
        {
            textmanejer.GetComponent<Text_names>().Text64();
        }
        if (this.gameObject.name == "night_button")//朝のライトマップ
        {
            textmanejer.GetComponent<Text_names>().Text65();
        }

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        textmanejer.GetComponent<Text_names>().Text_null();
    }
}

