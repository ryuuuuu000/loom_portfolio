using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    //主に家具の押されたボタンを管理しているスクリプト
    //メニューで押された家具ボタンによってbool型のスイッチがtrue.falseになる。
    //現在trueになっている家具によって左手コントローラーの先から表示する家具と設置する家具の切り替えを担当しているスクリプト。


    GameObject laserpointer;

    bool[] obj_check = new bool[44];

    void Start()
    {
        laserpointer = GameObject.Find("LaserPointer_L");
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            if (obj_check[0] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().eakon_Instance();
            }
            else if (obj_check[1] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().basket_tya_Instance();
            }
            else if (obj_check[2] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().basket_kuro_Instance();
            }
            else if (obj_check[3] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().bed_Instance();
            }
            else if (obj_check[4] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().kussyon_sikaku_Instance();
            }
            else if (obj_check[5] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().kussyon_maru_Instance();
            }
            else if (obj_check[6] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().todana_dai_kuro_Instance();
            }
            else if (obj_check[7] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().todana_dai_koitya_Instance();
            }
            else if (obj_check[8] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().todana_dai_usutya_Instance();
            }
            else if (obj_check[9] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().todana_syou_kuro_Instance();
            }
            else if (obj_check[10] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().todana_syou_koitya_Instance();
            }
            else if (obj_check[11] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().todana_syou_usutya_Instance();
            }
            else if (obj_check[12] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().sofa_siro_Instance();
            }
            else if (obj_check[13] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().sofa_aka_Instance();
            }
            else if (obj_check[14] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().sofa_gurey_Instance();
            }
            else if (obj_check[15] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().sofa_kuro_Instance();
            }
            else if (obj_check[16] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().isu_koitya_Instance();
            }
            else if (obj_check[17] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().isu_usutya_Instance();
            }
            else if (obj_check[18] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().tokei_kuro_Instance();
            }
            else if (obj_check[19] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().tokei_siro_Instance();
            }
            else if (obj_check[20] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().denki_syou_Instance();
            }
            else if (obj_check[21] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().denki_dai_Instance();
            }
            else if (obj_check[22] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().sugatakagami_Instance();
            }
            else if (obj_check[23] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().syokubutu_dai_Instance();
            }
            else if (obj_check[24] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().syokubutu_syou_Instance();
            }
            else if (obj_check[25] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().carpet_siro_Instance();
            }
            else if (obj_check[26] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().carpet_midori_Instance();
            }
            else if (obj_check[27] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().carpet_karahuru_Instance();
            }
            else if (obj_check[28] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().tana_syou_Instance();
            }
            else if (obj_check[29] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().tana_dai_Instance();
            }
            else if (obj_check[30] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().syokkidana_kuro_Instance();
            }
            else if (obj_check[31] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().syokkidana_koitya_Instance();
            }
            else if (obj_check[32] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().syokkidan_usutya_Instance();
            }
            else if (obj_check[33] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().table_syou_koitya_Instance();
            }
            else if (obj_check[34] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().table_syou_usutya_Instance();
            }
            else if (obj_check[35] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().table_sikaku_kuro_Instance();
            }
            else if (obj_check[36] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().table_sikaku_koitya_Instance();
            }
            else if (obj_check[37] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().table_sikaku_usutya_Instance();
            }
            else if (obj_check[38] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().normal_table_koitya_Instance();
            }
            else if (obj_check[39] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().normal_table_usutya_Instance();
            }
            else if (obj_check[40] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().tv_Instance();
            }
            else if (obj_check[41] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().consent_Instance();
            }
            else if (obj_check[42] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().reizouko_Instance();
            }
            else if (obj_check[43] == true)
            {
                laserpointer.GetComponent<LControllerLineRenderer>().densirenji_Instance();
            }
            else　
            {
                laserpointer.GetComponent<LControllerLineRenderer>().Instance_AllDestroy();
            }
        }


        if (obj_check[0] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().eakon_RayCheck();
        }

        else if (obj_check[1] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().basket_tya_RayCheck();
        }

        else if (obj_check[2] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().basket_kuro_RayCheck();
        }

        else if (obj_check[3] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().bed_RayCheck();
        }

        else if (obj_check[4] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().kussyon_sikaku_RayCheck();
        }

        else if (obj_check[5] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().kussyon_maru_RayCheck();
        }

        else if (obj_check[6] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().todana_dai_kuro_RayCheck();
        }

        else if (obj_check[7] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().todana_dai_koitya_RayCheck();
        }

        else if (obj_check[8] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().todana_dai_usutya_RayCheck();
        }

        else if (obj_check[9] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().todana_syou_kuro_RayCheck();
        }

        else if (obj_check[10] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().todana_syou_koitya_RayCheck();
        }

        else if (obj_check[11] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().todana_syou_usutya_RayCheck();
        }

        else if (obj_check[12] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().sofa_siro_RayCheck();
        }

        else if (obj_check[13] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().sofa_aka_RayCheck();
        }

        else if (obj_check[14] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().sofa_gurey_RayCheck();
        }

        else if (obj_check[15] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().sofa_kuro_RayCheck();
        }

        else if (obj_check[16] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().isu_koitya_RayCheck();
        }

        else if (obj_check[17] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().isu_usutya_RayCheck();
        }

        else if (obj_check[18] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().tokei_kuro_RayCheck();
        }

        else if (obj_check[19] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().tokei_siro_RayCheck();
        }

        else if (obj_check[20] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().denki_syou_RayCheck();
        }

        else if (obj_check[21] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().denki_dai_RayCheck();
        }

        else if (obj_check[22] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().sugatakagami_RayCheck();
        }

        else if (obj_check[23] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().syokubutu_dai_RayCheck();
        }

        else if (obj_check[24] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().syokubutu_syou_RayCheck();
        }

        else if (obj_check[25] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().carpet_siro_RayCheck();
        }

        else if (obj_check[26] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().carpet_midori_RayCheck();
        }

        else if (obj_check[27] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().carpet_karahuru_RayCheck();
        }

        else if (obj_check[28] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().tana_syou_RayCheck();
        }

        else if (obj_check[29] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().tana_dai_RayCheck();
        }

        else if (obj_check[30] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().syokkidana_kuro_RayCheck();
        }

        else if (obj_check[31] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().syokkidana_koitya_RayCheck();
        }

        else if (obj_check[32] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().syokkidana_usutya_RayCheck();
        }

        else if (obj_check[33] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().table_syou_koitya_RayCheck();
        }

        else if (obj_check[34] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().table_syou_usutya_RayCheck();
        }
        else if (obj_check[35] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().table_sikaku_kuro_RayCheck();
        }

        else if (obj_check[36] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().table_sikaku_koitya_RayCheck();
        }

        else if (obj_check[37] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().table_sikaku_usutya_RayCheck();
        }

        else if (obj_check[38] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().normal_table_koitya_RayCheck();
        }

        else if (obj_check[39] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().normal_table_usutya_RayCheck();
        }
        else if (obj_check[40] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().tv_RayCheck();
        }
        else if (obj_check[41] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().consent_RayCheck();
        }
        else if (obj_check[42] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().reizouko_RayCheck();
        }
        else if (obj_check[43] == true)
        {
            laserpointer.GetComponent<LControllerLineRenderer>().densirenji_RayCheck();
        }
        else
        {
            laserpointer.GetComponent<LControllerLineRenderer>().RayCheck_Alldestroy();
        }

    }

    public void Switch_eakon()
    {
        for(int i =0; i< obj_check.Length;i++)
        {
            obj_check[i] = false;
        }
        obj_check[0] = true;
    }

    public void Switch_basket_tya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[1] = true;
    }
    public void Switch_basket_kuro()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[2] = true;
    }
    public void Switch_bed()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[3] = true;
    }
    public void Switch_kussyon_sikaku()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[4] = true;
    }
    public void Switch_kussyon_maru()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[5] = true;
    }
    public void Switch_todana_dai_kuro()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[6] = true;
    }

    public void Switch_todana_dai_koitya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[7] = true;
    }

    public void Switch_todana_dai_usutya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[8] = true;
    }

    public void Switch_todana_syou_kuro()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[9] = true;
    }

    public void Switch_todana_syou_koitya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[10] = true;
    }

    public void Switch_todana_syou_usutya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[11] = true;
    }

    public void Switch_sofa_siro()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[12] = true;
    }

    public void Switch_sofa_aka()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[13] = true;
    }

    public void Switch_sofa_gurey()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[14] = true;
    }

    public void Switch_sofa_kuro()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[15] = true;
    }

    public void Switch_isu_koitya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[16] = true;
    }

    public void Switch_isu_usutya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[17] = true;
    }

    public void Switch_tokei_kuro()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[18] = true;
    }

    public void Switch_tokei_siro()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[19] = true;
    }

    public void Switch_denki_syou()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[20] = true;
    }

    public void Switch_denki_dai()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[21] = true;
    }

    public void Switch_sugatami()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[22] = true;
    }

    public void Switch_syokubutu_dai()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[23] = true;
    }

    public void Switch_syokubutu_syou()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[24] = true;
    }

    public void Switch_carpet_siro()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[25] = true;
    }

    public void Switch_carpet_midori()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[26] = true;
    }

    public void Switch_carpet_karahuru()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[27] = true;
    }

    public void Switch_tana_syou()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[28] = true;
    }

    public void Switch_tana_dai()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[29] = true;
    }

    public void Switch_syokkidana_kuro()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[30] = true;
    }

    public void Switch_syokkidana_koitya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[31] = true;
    }

    public void Switch_syokkidana_usutya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[32] = true;
    }

    public void Switch_table_syou_koitya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[33] = true;
    }

    public void Switch_table_syou_usutya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[34] = true;
    }

    public void Switch_table_sikaku_kuro()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[35] = true;
    }

    public void Switch_table_sikaku_koitya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[36] = true;
    }

    public void Switch_table_sikaku_usutya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[37] = true;
    }

    public void Switch_normal_table_koitya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[38] = true;
    }

    public void Switch_normal_table_usutya()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[39] = true;
    }

    public void Switch_tv()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[40] = true;
    }
    public void Switch_consent()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[41] = true;
    }
    public void Switch_reizouko()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[42] = true;
    }
    public void Switch_densirenji()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
        obj_check[43] = true;
    }

    public void Switch_ALLcancel()
    {
        for (int i = 0; i < obj_check.Length; i++)
        {
            obj_check[i] = false;
        }
    }


}
