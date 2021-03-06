using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class  furniture_inputbutton : MonoBehaviour,IPointerDownHandler,IPointerEnterHandler,IPointerExitHandler
{
    //家具のボタンが押された時の処理をしているスクリプト



    GameObject laserpointerL;//左のコントローラーを主に操作しているオブジェクト

    void Start()

    {
        laserpointerL = GameObject.Find("Switch_manejer");
    }
 
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {

        //押されたボタンの名前によって、表示する家具オブジェクト、設置できる家具オブジェクトを変更している
        if (this.gameObject.name == "ac01_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_eakon();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline();
        }
        if (this.gameObject.name == "basket01_1_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_basket_tya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline1();
        }
        if (this.gameObject.name == "basket01_2_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_basket_kuro();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline2();
        }
        if (this.gameObject.name == "bed01_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_bed();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline3();
        }
        if (this.gameObject.name == "pillow02_1_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_kussyon_sikaku();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline4();
        }
        if (this.gameObject.name == "pillow3_1_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_kussyon_maru();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline5();
        }
        if (this.gameObject.name == "cabinet01_1_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_todana_dai_kuro();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline6();
        }
        if (this.gameObject.name == "cabinet01_2_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_todana_dai_koitya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline7();
        }
        if (this.gameObject.name == "cabinet01_3_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_todana_dai_usutya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline8();
        }
        if (this.gameObject.name == "cabinet02_1_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_todana_syou_kuro();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline9();
        }
        if (this.gameObject.name == "cabinet02_2_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_todana_syou_koitya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline10();
        }
        if (this.gameObject.name == "cabinet02_3_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_todana_syou_usutya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline11();
        }
        if (this.gameObject.name == "chair01_1_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_sofa_siro();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline12();
        }
        if (this.gameObject.name == "chair01_2_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_sofa_aka();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline13();
        }
        if (this.gameObject.name == "chair01_3_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_sofa_gurey();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline14();
        }
        if (this.gameObject.name == "chair01_4_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_sofa_kuro();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline15();
        }
        if (this.gameObject.name == "chair02_1_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_isu_koitya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline16();
        }
        if (this.gameObject.name == "chair02_2_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_isu_usutya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline17();
        }
        if (this.gameObject.name == "clock01_1_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_tokei_kuro();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline18();
        }
        if (this.gameObject.name == "clock01_2_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_tokei_siro();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline19();
        }
        if (this.gameObject.name == "lamp03_on_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_denki_syou();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline20();
        }
        if (this.gameObject.name == "lamp05_on_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_denki_dai();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline21();
        }
        if (this.gameObject.name == "mirror03_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_sugatami();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline22();
        }
        if (this.gameObject.name == "plant01_2_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_syokubutu_dai();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline23();
        }
        if (this.gameObject.name == "plant02_2_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_syokubutu_syou();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline24();
        }
        if (this.gameObject.name == "rug01_1_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_carpet_siro();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline25();
        }
        if (this.gameObject.name == "rug01_2_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_carpet_midori();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline26();
        }
        if (this.gameObject.name == "rug01_3_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_carpet_karahuru();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline27();
        }
        if (this.gameObject.name == "shelf01_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_tana_syou();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline28();
        }
        if (this.gameObject.name == "shelf02_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_tana_dai();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline29();
        }
        if (this.gameObject.name == "sideboard01_1_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_syokkidana_kuro();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline30();
        }
        if (this.gameObject.name == "sideboard01_2_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_syokkidana_koitya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline31();
        }
        if (this.gameObject.name == "sideboard01_3_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_syokkidana_usutya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline32();

        }
        if (this.gameObject.name == "table01_1_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_table_syou_koitya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline33();
        }
        if (this.gameObject.name == "table01_2_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_table_syou_usutya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline34();
        }
        if (this.gameObject.name == "table02_1_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_table_sikaku_kuro();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline35();
        }
        if (this.gameObject.name == "table02_2_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_table_sikaku_koitya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline36();
        }
        if (this.gameObject.name == "table02_3_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_table_sikaku_usutya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline37();
        }
        if (this.gameObject.name == "table03_1_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_normal_table_koitya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline38();
        }
        if (this.gameObject.name == "table03_2_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_normal_table_usutya();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline39();
        }

        if (this.gameObject.name == "tv01_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_tv();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline40();
        }
        if (this.gameObject.name == "outlet01_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_consent();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline41();
        }
        if (this.gameObject.name == "fridge01_1_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_reizouko();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline42();
        }
        if (this.gameObject.name == "microwave01_Button")
        {
            laserpointerL.GetComponent<Switch>().Switch_densirenji();
            laserpointerL.GetComponent<Outlinebutton>().buttonoutline43();
        }


        //メニュー左のアウトライン操作
        if (this.gameObject.name == "home_button")
        {
            laserpointerL.GetComponent<Outlinebutton>().menubuttonoutline1();
        }
        if (this.gameObject.name == "cancel_button")
        {
            laserpointerL.GetComponent<Outlinebutton>().menubuttonoutline2();
            laserpointerL.GetComponent<Switch>().Switch_ALLcancel();
        }
        if (this.gameObject.name == "setting_button")
        {
            laserpointerL.GetComponent<Outlinebutton>().menubuttonoutline4();
        }


        //BGMボタンのアウトライン操作
        if(this.gameObject.name == "bgm_button1")
        {
            laserpointerL.GetComponent<Outlinebutton>().bgmbutton_outline0();
        }
        if (this.gameObject.name == "bgm_button2")
        {
            laserpointerL.GetComponent<Outlinebutton>().bgmbutton_outline1();
        }
        if (this.gameObject.name == "bgm_button3")
        {
            laserpointerL.GetComponent<Outlinebutton>().bgmbutton_outline2();
        }
        if (this.gameObject.name == "bgm_button4")
        {
            laserpointerL.GetComponent<Outlinebutton>().bgmbutton_outline3();
        }
        if (this.gameObject.name == "bgm_button5")
        {
            laserpointerL.GetComponent<Outlinebutton>().bgmbutton_outline4();
        }
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        //設定画面のアウトライン操作（レイがボタンに乗ったら処理される）
        if (this.gameObject.name == "sound_button")
        {
            laserpointerL.GetComponent<Outlinebutton>().settingbutton_outline0();
        }
        if(this.gameObject.name == "setumeisyo_button")
        {
            laserpointerL.GetComponent<Outlinebutton>().settingbutton_outline1();
        }
        if (this.gameObject.name == "taitle_button")
        {
            laserpointerL.GetComponent<Outlinebutton>().settingbutton_outline2();
        }
        if (this.gameObject.name == "riset_button")
        {
            laserpointerL.GetComponent<Outlinebutton>().settingbutton_outline3();
        }

        if(this.gameObject.name == "lightswich_button")
        {
            laserpointerL.GetComponent<Outlinebutton>().settingbutton_outline4();
        }
        if(this.gameObject.name == "morning_button")
        {
            laserpointerL.GetComponent<Outlinebutton>().settingbutton_outline5();
        }
        if(this.gameObject.name == "sunset_button")
        {
            laserpointerL.GetComponent<Outlinebutton>().settingbutton_outline6();
        }
        if(this.gameObject.name == "night_button")
        {
            laserpointerL.GetComponent<Outlinebutton>().settingbutton_outline7();
        }

        //BGMが設定ができるパネル。戻るボタンのアウトライン
        if (this.gameObject.name == "return_button")
        {
            laserpointerL.GetComponent<Outlinebutton>().bgmbutton_outline5();
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //設定パネルでレイが当たっていない時にアウトラインを消す
        laserpointerL.GetComponent<Outlinebutton>().settingbutton_outline_false();
        //BGMが設定できるパネルで例が当たっていなければアウトラインを消す
        laserpointerL.GetComponent<Outlinebutton>().bgmsetting_outline_false();
    }
}
