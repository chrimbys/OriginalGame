using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public GameObject unitychan;
    private Vector3 offset;

    void Start()
    {
        
    }

    void LateUpdate()
    {
        // まずはカメラ位置をプレイヤーに追従させて...

        // プレイヤーを中心にカメラを回すと、プレイヤーとカメラの相対位置が
        // 変化するはずなので、RotateAroundの後でoffsetを更新する
        if (Input.GetMouseButton(1))
        {
            if (Input.mousePosition.x < Screen.width * 0.5f)
            {
                transform.RotateAround(unitychan.transform.position, Vector3.up, -2.0f);
                // transform.RotateAround(Vector3.zero,Vector3.up,-2.0f);
            }
            if (Input.mousePosition.x > Screen.width * 0.5f)
            {
                transform.RotateAround(unitychan.transform.position, Vector3.up, 2.0f);
                // transform.RotateAround(Vector3.zero,Vector3.up,-2.0f);
            }
        }
    }
}
