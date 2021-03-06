using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class JoyStickMove : MonoBehaviour
{
    float angle = 30;

    void Update()
    {
        ChangeDirection();
        Move();
    }

    //OVRCameraRigの角度変更
    void ChangeDirection()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickLeft))
        {
            this.transform.Rotate(0, -angle, 0);
        }
        else if (OVRInput.GetDown(OVRInput.RawButton.RThumbstickRight))
        {
            this.transform.Rotate(0, angle, 0);
        }
    }

    void Move()
    {
        //右ジョイスティックの情報取得
        Vector2 stickR = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);
        //OVRCameraRigの位置変更
        this.transform.position += this.transform.rotation * (new Vector3((stickR.x)*0.02f, 0, (stickR.y)*0.02f));
    }
}