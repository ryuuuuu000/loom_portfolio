using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerLineRenderer : MonoBehaviour
{
    //主に右コントローラーの処理をしている



    public Transform rayTransform = null;
    public LineRenderer lineRenderer = null;
    public float maxRayDistance = 500.0f;

    ////スティックを横にした時に回転する角度
    //float angle = 30;

    [SerializeField]
    GameObject SE2;

    private void Start()
    {
        GameObject.FindGameObjectWithTag("aaa");
    }

    void Update()
    {
        // コントローラの位置と向いている方向からRayを作成
        Ray laserPointer = new Ray(rayTransform.position, rayTransform.forward);

        // 作成したRay上にColliderがあるか判定
        RaycastHit hit;
        if (Physics.Raycast(laserPointer, out hit, maxRayDistance))
        {
            // Colliderがあれば、衝突箇所までレーザーを描画
            renderLaserToHit(laserPointer, hit);

            GameObject pointedObject = hit.collider.gameObject;
        }
        else
        {
            // Colliderがなければ、最大長のレーザーを描画
            renderLaserFullLength(laserPointer);
        }

        //Bボタンを押した際の処理（家具オブジェクトを子オブジェクトにして掴めるように）
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            if (Physics.Raycast(laserPointer, out hit, 100.0f))
            {
                if (hit.collider.tag == "cube")
                {
                    hit.collider.gameObject.transform.parent = rayTransform.transform;
                }
            }
        }

        //Bボタンを離した際の処理（このオブジェクトの子オブジェクトを空にすることによってつかんでいたオブジェクトを離す）
        if (OVRInput.GetUp(OVRInput.RawButton.B))
        {
            for (int i = 0; i < rayTransform.transform.childCount; i++)
            {
                var child = rayTransform.transform.GetChild(i);
                if (child.tag == "cube")
                {
                    child.parent = null;
                }
            }
        }

        //右人差し指トリガーを押した際の処理（もし家具オブジェクトにレイがあたっていればオブジェクトを削除＆削除音をプレイ）
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            if (Physics.Raycast(laserPointer, out hit, 100.0f))
            {
                if (hit.collider.tag == "cube")
                {
                    Destroy(hit.collider.gameObject);
                    SE2.GetComponent<AudioSource>().Play();
                }
            }
        }

        //レイが当たった家具オブジェクトのアウトラインをtrueに
        if (Physics.Raycast(laserPointer, out hit, 100))
        {
            if (hit.collider.tag == "cube")
            {
                hit.collider.GetComponent<Outline>().enabled = true;
            }
        }

        //レイが当たったオブジェクトが家具ではなかったら全てのアウトラインをfalseに
        if (Physics.Raycast(laserPointer, out hit, 100))
        {
            if (hit.collider.tag != "cube")
            {
                GameObject[] objects = GameObject.FindGameObjectsWithTag("cube");
                for (int i = 0; i < objects.Length; i++)
                {
                    objects[i].GetComponent<Outline>().enabled = false;
                }
            }
        }

        //レイが当たっていなかったら家具のアウトラインを全てfalseに
        if (!Physics.Raycast(laserPointer, out hit, 100))
        {
            GameObject[] objects = GameObject.FindGameObjectsWithTag("cube");
            for (int i = 0; i < objects.Length; i++)
            {
                objects[i].GetComponent<Outline>().enabled = false;
            }
        }

    }

    private void renderLaserToHit(Ray ray, RaycastHit hit)
    {
        renderLaser(ray.origin, hit.point);
    }

    private void renderLaserFullLength(Ray ray)
    {
        renderLaser(ray.origin, ray.origin + ray.direction * maxRayDistance);
    }

    private void renderLaser(Vector3 from, Vector3 to)
    {
        // Line Rendererの1点目と2点目の位置を指定する
        lineRenderer.SetPosition(0, from);
        lineRenderer.SetPosition(1, to);
    }

}
