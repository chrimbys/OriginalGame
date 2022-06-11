using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCounter : MonoBehaviour
{
    public int keyCount;

    public int maxkeyCount;

    private KeyCounter keyCounter;

    private int shownKeyCount;



    // Start is called before the first frame update
    void Start()
    {
        maxkeyCount = GameObject.FindGameObjectsWithTag("TargetTag").Length;
        this.keyCounter = GetComponent<KeyCounter>();

        this.UpdateKeyCount();

    }

    // Update is called once per frame
    void Update()
    {
        /*

 //デバッグ用　エディタ上であれば実行
 if (Application.isEditor == true)
 {
     //スペースキーが押されたら鍵の数を増やす
     if (Input.GetKeyDown(KeyCode.Space))
     {
         keyCount++;
     }
 }

 */

    }

    private void UpdateKeyCount()
    {
        this.keyCounter.GetComponent<Text>().text = this.keyCount + "/" + this.maxkeyCount;
        this.shownKeyCount = this.keyCount;
    }

}
