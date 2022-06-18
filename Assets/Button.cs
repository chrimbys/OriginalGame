using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    private GameObject sKey1;
    private GameObject sKey2;
    private GameObject sKey3;
    private GameObject treasureChest;
    private GameObject unitychan;
    private GameObject entranceDoor;

    private float Distance1;
    private float Distance2;
    private float Distance3;
    private float Distance4;
    private float Distance5;

    float ItemGetDis = 1.5f;
    float GoalItemDis = 2.5f;

    private GameObject MessageText;

    private KeyCounter keyCounter;

    Fader fader;

    public void Start()
    {
        sKey1 = GameObject.Find("SKey1");
        sKey2 = GameObject.Find("SKey2");
        sKey3 = GameObject.Find("SKey3");
        treasureChest = GameObject.Find("TreasureChest");
        unitychan = GameObject.Find("unitychan");
        entranceDoor = GameObject.Find("EntranceDoor");
        MessageText = GameObject.Find("MessageText");
        keyCounter = GameObject.Find("KeyCounter").GetComponent<KeyCounter>();
        fader = GameObject.Find("Fader").GetComponent<Fader>();
    }

    public void Update()
    {
        if (sKey1 != null)
        { Distance1 = (sKey1.transform.position - unitychan.transform.position).sqrMagnitude; }
        if (sKey2 != null)
        { Distance2 = (sKey2.transform.position - unitychan.transform.position).sqrMagnitude; }
        if (sKey3 != null)
        { Distance3 = (sKey3.transform.position - unitychan.transform.position).sqrMagnitude; }
        if (treasureChest != null)
        { Distance4 = (treasureChest.transform.position - unitychan.transform.position).sqrMagnitude; }
        
         Distance5 = (entranceDoor.transform.position - unitychan.transform.position).sqrMagnitude; 

        /*
        if (Application.isEditor == true)
        {
          if(Input.GetKeyDown(KeyCode.Space))
           {keyCounter.gKeyCount++;}
        }
        */



    }

    public void OnClick()
    {

        if (Distance1 <= ItemGetDis && sKey1)
        {
            Debug.Log("sKey1");
            this.MessageText.GetComponent<Text>().text = "銀の鍵を手に入れた!";
            keyCounter.skeyCount++;

            StartCoroutine("TextSet");

            Destroy(sKey1);

        }
        if (Distance2 <= ItemGetDis)
        {
            Debug.Log("sKey2");
            this.MessageText.GetComponent<Text>().text = "銀の鍵を手に入れた!";
            StartCoroutine("TextSet");
            keyCounter.skeyCount++;

            Destroy(sKey2);


        }
        if (Distance3 <= ItemGetDis && sKey3)
        {
            Debug.Log("sKey3");

            this.MessageText.GetComponent<Text>().text = "銀の鍵を手に入れた!";
            StartCoroutine("TextSet");
            keyCounter.skeyCount++;

            Destroy(sKey3);


        }

        //sKey3個で宝箱から鍵がゲットできる
        if(Distance4 <= GoalItemDis && treasureChest)
        {
            Debug.Log("tresureChest");

            this.MessageText.GetComponent<Text>().text = "家の鍵を手に入れた!";
            StartCoroutine("TextSet");

            keyCounter.KeyType = true;
            keyCounter.gKeyCount++;

            Destroy(treasureChest);

        }
        if (Distance5 <= ItemGetDis)
        {
            Debug.Log("EntranceDoor");
            if (keyCounter.gKeyCount == keyCounter.maxgKeyCount)
            {
                Debug.Log("Clear");
                fader.isFadeOut = true;
            }


        }



    }


    IEnumerator TextSet()
    {
        yield return new WaitForSeconds(1.0f);
        this.MessageText.GetComponent<Text>().text = "";
    }
}
