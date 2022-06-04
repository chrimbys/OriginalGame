using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticDoor : MonoBehaviour
{
    //　ドアのアニメーター
    [SerializeField]
    [Tooltip("自動ドアのアニメーター")]
    private Animator DoorSingleAnimator;


    /// <summary>
    /// 自動ドア検知エリアに入った時
    /// </summary>
    /// <param name="other"></param>
	private void OnTriggerEnter(Collider other)
    {
        // アニメーションパラメータをtrueにする。(ドアが開く)
        DoorSingleAnimator.SetBool("isOpen_Obj_1", false);
        Debug.Log("Open");
    }

    /// <summary>
    /// 自動ドア検知エリアを出た時
    /// </summary>
    /// <param name="other"></param>
	private void OnTriggerExit(Collider other)
    {
        // アニメーションパラメータをfalseにする。(ドアが閉まる)
        DoorSingleAnimator.SetBool("isOpen_Obj_1", true);
        Debug.Log("Close");
    }
}
