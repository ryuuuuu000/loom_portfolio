using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Input_torisetu : MonoBehaviour,IPointerEnterHandler,IPointerDownHandler,IPointerExitHandler
{
    //操作説明のボタン入力を管理しているスクリプト


    GameObject textmanejer;

    GameObject switchmanejer;


    void Start()
    {
        textmanejer = GameObject.Find("Text_manejer");

        switchmanejer = GameObject.Find("Switch_manejer");

    }

    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)//押したら
    {
        //取説のテキストの切り替え
        if (this.gameObject.name == "next_Button")
        {
            textmanejer.GetComponent<Text_torisetu>().pluscount();
        }
        if (this.gameObject.name == "return_Button")
        {
            textmanejer.GetComponent<Text_torisetu>().mainasucount();
        }
    }

    public void OnPointerEnter(PointerEventData eventData)//重なったら
    {

        //アウトラインの切り替え
        if (this.gameObject.name == "next_Button")//次へ
        {
            switchmanejer.GetComponent<Outlinebutton>().torisetubutton_outline1();
        }
        if (this.gameObject.name == "return_Button")//前へ
        {
            switchmanejer.GetComponent<Outlinebutton>().torisetubutton_outline2();
        }
        if (this.gameObject.name == "batu_button")//×ボタン
        {
        }
        if (this.gameObject.name == "end_Button")//閉じる
        {
            switchmanejer.GetComponent<Outlinebutton>().torisetubutton_outline3();
        }

        if (this.gameObject.name == "yes_Button")//本当に閉じますか？はい。
        {
            switchmanejer.GetComponent<Outlinebutton>().torisetubutton_outline4();
        }
        if (this.gameObject.name == "no_Button")//本当に閉じますか？いいえ
        {
            switchmanejer.GetComponent<Outlinebutton>().torisetubutton_outline5();
        }


    }

    public void OnPointerExit(PointerEventData eventData)
    {
        switchmanejer.GetComponent<Outlinebutton>().torisetubutton_outline_false();//ボタンからカーソル離れたら取説アウトラインをfalseに

    }
}
