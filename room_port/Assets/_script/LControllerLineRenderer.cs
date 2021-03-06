using System.Collections;
using System.Collections.Generic;
using OVR.OpenVR;
using UnityEngine;

public class LControllerLineRenderer : MonoBehaviour
{
    //主に左手コントローラーの入力を担当しているスクリプト


    [SerializeField] float LmaxRayDistance = 500.0f;

    [SerializeField] Transform LrayTransform;
    [SerializeField] LineRenderer LlineRenderer = null;

    //レイ関連
    public LayerMask mask;
    Ray Lray;
    RaycastHit Lhit;


    //オブジェクト管理
    [SerializeField] GameObject[] objprefab = new GameObject[44];
    [SerializeField] GameObject[] objprefabInstance = new GameObject[44];

    //オブジェクトの角度を格納
    Transform objtransform;

    //メニュー
    [SerializeField] GameObject Menutab;
    bool menuactive = false;
    

    private void Start()
    {

        mask = ~(1 << 8);

        for (int i = 0; i < objprefab.Length; i++)//配列の要素数文回している
        {
            objprefab[i] = Instantiate(objprefab[i]);//配列の変数に家具オブジェクトのインスタンスを入れている

            objtransform = objprefab[i].transform;

        }

    }



    void Update()
    {
        // コントローラの位置と向いている方向からRayを作成
        Lray = new Ray(LrayTransform.position, LrayTransform.forward);

        //作成したRay上にColliderがあるか判定
        if (Physics.Raycast(Lray, out Lhit, LmaxRayDistance))
        {
            // Colliderがあれば、衝突箇所までレーザーを描画
            renderLaserToHit(Lray, Lhit);

            GameObject pointedObject = Lhit.collider.gameObject;
        }
        else
        {
            // Colliderがなければ、最大長のレーザーを描画
            renderLaserFullLength(Lray);
        }



        //ボタンを押したら全てのオブジェクトがY軸に90度回転
        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            for (int i = 0; i < objprefab.Length; i++)
            {
                objtransform.Rotate(0, 45, 0);
                objtransform = objprefab[i].transform;
            }
        }

        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))//左人差し指トリガーを押した際の処理
        {
            //メニューが開いていれば閉じる、ひらいていなければ開く
            if (Menutab.activeSelf == false)
            {
                Menutab.SetActive(true);
                menuactive = true;
            }
            else if (Menutab.activeSelf == true)
            {
                Menutab.SetActive(false);
                menuactive = false;
            }
        }

    }






    //レイの先に表示するオブジェクト、Xボタンを押したときに設置するオブジェクトのメソッド。
    //このメソッドはメニューの押されたボタンによって呼び出されるメソッドが変わる。

    public void eakon_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[0].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);
            
            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 0)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void eakon_Instance()
    {
        Instantiate(objprefabInstance[0],objprefab[0].transform.position,objprefab[0].transform.rotation);
    }



    public void basket_tya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        { 

            objprefab[1].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 1)
                {
                    objprefab[i].SetActive(true);
                }
            }

        }
    }

    public void basket_tya_Instance()
    {
         Instantiate(objprefabInstance[1], objprefab[1].transform.position, objprefab[1].transform.rotation);
    }


    public void basket_kuro_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[2].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 2)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void basket_kuro_Instance()
    {
        Instantiate(objprefabInstance[2], objprefab[2].transform.position, objprefab[2].transform.rotation);
    }


    public void bed_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[3].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 3)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void bed_Instance()
    {
        Instantiate(objprefabInstance[3], objprefab[3].transform.position, objprefab[3].transform.rotation);
    }


    public void kussyon_sikaku_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[4].transform.position = new Vector3(Lhit.point.x, Lhit.point.y+0.3f, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 4)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void kussyon_sikaku_Instance()
    {
        Instantiate(objprefabInstance[4], objprefab[4].transform.position, objprefab[4].transform.rotation);
    }


    public void kussyon_maru_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[5].transform.position = new Vector3(Lhit.point.x, Lhit.point.y+0.1f, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 5)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void kussyon_maru_Instance()
    {
        Instantiate(objprefabInstance[5], objprefab[5].transform.position, objprefab[5].transform.rotation);
    }


    public void todana_dai_kuro_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[6].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 6)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void todana_dai_kuro_Instance()
    {
        Instantiate(objprefabInstance[6], objprefab[6].transform.position, objprefab[6].transform.rotation);
    }


    public void todana_dai_koitya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[7].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 7)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void todana_dai_koitya_Instance()
    {
        Instantiate(objprefabInstance[7], objprefab[7].transform.position, objprefab[7].transform.rotation);
    }


    public void todana_dai_usutya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[8].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 8)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void todana_dai_usutya_Instance()
    {
        Instantiate(objprefabInstance[8], objprefab[8].transform.position, objprefab[8].transform.rotation);
    }


    public void todana_syou_kuro_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[9].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 9)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void todana_syou_kuro_Instance()
    {
        Instantiate(objprefabInstance[9], objprefab[9].transform.position, objprefab[9].transform.rotation);
    }


    public void todana_syou_koitya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[10].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 10)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void todana_syou_koitya_Instance()
    {
        Instantiate(objprefabInstance[10], objprefab[10].transform.position, objprefab[10].transform.rotation);
    }


    public void todana_syou_usutya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[11].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 11)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void todana_syou_usutya_Instance()
    {
        Instantiate(objprefabInstance[11], objprefab[11].transform.position, objprefab[11].transform.rotation);
    }


    public void sofa_siro_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[12].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 12)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void sofa_siro_Instance()
    {
        Instantiate(objprefabInstance[12], objprefab[12].transform.position, objprefab[12].transform.rotation);
    }


    public void sofa_aka_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[13].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 13)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void sofa_aka_Instance()
    {
        Instantiate(objprefabInstance[13], objprefab[13].transform.position, objprefab[13].transform.rotation);
    }


    public void sofa_gurey_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[14].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 14)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void sofa_gurey_Instance()
    {
        Instantiate(objprefabInstance[14], objprefab[14].transform.position, objprefab[14].transform.rotation);
    }


    public void sofa_kuro_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[15].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 15)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void sofa_kuro_Instance()
    {
        Instantiate(objprefabInstance[15], objprefab[15].transform.position, objprefab[15].transform.rotation);
    }


    public void isu_koitya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[16].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 16)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void isu_koitya_Instance()
    {
        Instantiate(objprefabInstance[16], objprefab[16].transform.position, objprefab[16].transform.rotation);
    }


    public void isu_usutya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[17].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 17)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void isu_usutya_Instance()
    {
        Instantiate(objprefabInstance[17], objprefab[17].transform.position, objprefab[17].transform.rotation);
    }


    public void tokei_kuro_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[18].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 18)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void tokei_kuro_Instance()
    {
        Instantiate(objprefabInstance[18], objprefab[18].transform.position, objprefab[18].transform.rotation);
    }


    public void tokei_siro_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[19].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 19)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void tokei_siro_Instance()
    {
        Instantiate(objprefabInstance[19], objprefab[19].transform.position, objprefab[19].transform.rotation);
    }


    public void denki_syou_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[20].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 20)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void denki_syou_Instance()
    {
        Instantiate(objprefabInstance[20], objprefab[20].transform.position, objprefab[20].transform.rotation);
    }


    public void denki_dai_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[21].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 21)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void denki_dai_Instance()
    {
        Instantiate(objprefabInstance[21], objprefab[21].transform.position, objprefab[21].transform.rotation);
    }


    public void sugatakagami_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[22].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 22)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void sugatakagami_Instance()
    {
        Instantiate(objprefabInstance[22], objprefab[22].transform.position, objprefab[22].transform.rotation);
    }


    public void syokubutu_dai_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[23].transform.position = new Vector3(Lhit.point.x, Lhit.point.y+0.5f, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 23)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void syokubutu_dai_Instance()
    {
        Instantiate(objprefabInstance[23], objprefab[23].transform.position, objprefab[23].transform.rotation);
    }


    public void syokubutu_syou_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[24].transform.position = new Vector3(Lhit.point.x, Lhit.point.y+0.1f, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 24)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void syokubutu_syou_Instance()
    {
        Instantiate(objprefabInstance[24], objprefab[24].transform.position, objprefab[24].transform.rotation);
    }


    public void carpet_siro_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[25].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 25)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void carpet_siro_Instance()
    {
        Instantiate(objprefabInstance[25], objprefab[25].transform.position, objprefab[25].transform.rotation);
    }


    public void carpet_midori_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[26].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 26)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void carpet_midori_Instance()
    {
        Instantiate(objprefabInstance[26], objprefab[26].transform.position, objprefab[26].transform.rotation);
    }


    public void carpet_karahuru_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[27].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 27)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void carpet_karahuru_Instance()
    {
        Instantiate(objprefabInstance[27], objprefab[27].transform.position, objprefab[27].transform.rotation);
    }


    public void tana_syou_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[28].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 28)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void tana_syou_Instance()
    {
        Instantiate(objprefabInstance[28], objprefab[28].transform.position, objprefab[28].transform.rotation);
    }

    public void tana_dai_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[29].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 29)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void tana_dai_Instance()
    {
        Instantiate(objprefabInstance[29], objprefab[29].transform.position, objprefab[29].transform.rotation);
    }


    public void syokkidana_kuro_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[30].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 30)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void syokkidana_kuro_Instance()
    {
        Instantiate(objprefabInstance[30], objprefab[30].transform.position, objprefab[30].transform.rotation);
    }


    public void syokkidana_koitya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[31].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 31)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void syokkidana_koitya_Instance()
    {
        Instantiate(objprefabInstance[31], objprefab[31].transform.position, objprefab[31].transform.rotation);
    }


    public void syokkidana_usutya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[32].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 32)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void syokkidan_usutya_Instance()
    {
        Instantiate(objprefabInstance[32], objprefab[32].transform.position, objprefab[32].transform.rotation);
    }


    public void table_syou_koitya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[33].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 33)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void table_syou_koitya_Instance()
    {
        Instantiate(objprefabInstance[33], objprefab[33].transform.position, objprefab[33].transform.rotation);
    }


    public void table_syou_usutya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[34].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 34)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void table_syou_usutya_Instance()
    {
        Instantiate(objprefabInstance[34], objprefab[34].transform.position, objprefab[34].transform.rotation);
    }


    public void table_sikaku_kuro_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[35].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 35)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void table_sikaku_kuro_Instance()
    {
        Instantiate(objprefabInstance[35], objprefab[35].transform.position, objprefab[35].transform.rotation);
    }


    public void table_sikaku_koitya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[36].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 36)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void table_sikaku_koitya_Instance()
    {
        Instantiate(objprefabInstance[36], objprefab[36].transform.position, objprefab[36].transform.rotation);
    }


    public void table_sikaku_usutya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[37].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 37)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void table_sikaku_usutya_Instance()
    {
        Instantiate(objprefabInstance[37], objprefab[37].transform.position, objprefab[37].transform.rotation);
    }


    public void normal_table_koitya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[38].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 38)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void normal_table_koitya_Instance()
    {
        Instantiate(objprefabInstance[38], objprefab[38].transform.position, objprefab[38].transform.rotation);
    }


    public void normal_table_usutya_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[39].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 39)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void normal_table_usutya_Instance()
    {
        Instantiate(objprefabInstance[39], objprefab[39].transform.position, objprefab[39].transform.rotation);
    }


    public void tv_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[40].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 40)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void tv_Instance()
    {
        Instantiate(objprefabInstance[40], objprefab[40].transform.position, objprefab[40].transform.rotation);
    }


    public void consent_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[41].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 41)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void consent_Instance()
    {
        Instantiate(objprefabInstance[41], objprefab[41].transform.position, objprefab[41].transform.rotation);
    }


    public void reizouko_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[42].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 42)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void reizouko_Instance()
    {
        Instantiate(objprefabInstance[42], objprefab[42].transform.position, objprefab[42].transform.rotation);
    }


    public void densirenji_RayCheck()
    {
        if (Physics.Raycast(Lray, out Lhit, 100, mask))
        {
            objprefab[43].transform.position = new Vector3(Lhit.point.x, Lhit.point.y, Lhit.point.z);

            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
                if (i == 43)
                {
                    objprefab[i].SetActive(true);
                }
            }
        }
    }

    public void densirenji_Instance()
    {
        Instantiate(objprefabInstance[43], objprefab[43].transform.position, objprefab[43].transform.rotation);
    }

    public void RayCheck_Alldestroy()
    {
            for (int i = 0; i < objprefab.Length; i++)
            {
                objprefab[i].SetActive(false);
            }
    }

    public void Instance_AllDestroy()
    {
    }



    //レイを可視化
    private void renderLaserToHit(Ray ray, RaycastHit hit)
    {
        renderLaser(ray.origin, hit.point);
    }

    private void renderLaserFullLength(Ray ray)
    {
        renderLaser(ray.origin, ray.origin + ray.direction * LmaxRayDistance);
    }

    private void renderLaser(Vector3 from, Vector3 to)
    {
        // Line Rendererの1点目と2点目の位置を指定する
        LlineRenderer.SetPosition(0, from);
        LlineRenderer.SetPosition(1, to);
    }


}
