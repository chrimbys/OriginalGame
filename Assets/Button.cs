using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    private GameObject Key1;
    private GameObject Key2;
    private GameObject Key3;

    private GameObject unitychan;

    private float Distance1;
    private float Distance2;
    private float Distance3;
    float ItemGetDis = 1.5f;

    private GameObject MessageText;

    private KeyCounter keyCounter;

    public void Start()
    {
        Key1 = GameObject.Find("Key1");
        Key2 = GameObject.Find("Key2");
        Key3 = GameObject.Find("Key3");
        unitychan = GameObject.Find("unitychan");
        MessageText = GameObject.Find("MessageText");
        keyCounter = GameObject.Find("KeyCounter").GetComponent<KeyCounter>();
    }

    public void Update()
    {
        if (Key1 != null)
        { Distance1 = (Key1.transform.position - unitychan.transform.position).sqrMagnitude; }
        if (Key2 != null)
        { Distance2 = (Key2.transform.position - unitychan.transform.position).sqrMagnitude; }
        if (Key3 != null)
        { Distance3 = (Key3.transform.position - unitychan.transform.position).sqrMagnitude; }




    }

    public void OnClick()
    {
        Debug.Log(Distance3);


        if (Distance1 <= ItemGetDis )
        {
            Debug.Log("Key1");
            this.MessageText.GetComponent<Text>().text = "鍵を手に入れた!";
            keyCounter.keyCount++;

            StartCoroutine("TextSet");

            Destroy(Key1);

        }
        if (Distance2 <= ItemGetDis)
        {
            Debug.Log("Key2");
            this.MessageText.GetComponent<Text>().text = "鍵を手に入れた!";
            StartCoroutine("TextSet");

            Destroy(Key2);


        }
        if (Distance3 <= ItemGetDis)
        {
            Debug.Log("Key3");

            this.MessageText.GetComponent<Text>().text = "鍵を手に入れた!";
            StartCoroutine("TextSet");

            Destroy(Key3);


        }


    }

    IEnumerator TextSet()
    {
        yield return new WaitForSeconds(1.0f);
        this.MessageText.GetComponent<Text>().text = "";
    }
}
