using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetKeyController : MonoBehaviour
{
    private GameObject[] Keys;

    private GameObject unitychan;

    private float Distance;
    float ItemGetDis = 1.5f;

    private GameObject MessageText;



    public void Start()
    {
        Keys = GameObject.FindGameObjectsWithTag("TartgetTag");
        unitychan = GameObject.Find("unitychan");
        MessageText = GameObject.Find("MessageText");

    }

    public void Update()
    {
        foreach(GameObject Key in Keys)
        { Distance = (Key.transform.position - unitychan.transform.position).sqrMagnitude; }




    }

    public void OnClick()
    {


        if (Distance <= ItemGetDis)
        {
            
            this.MessageText.GetComponent<Text>().text = "鍵を手に入れた!";
            StartCoroutine("TextSet");

            Destroy(gameObject);

        }


    }

    IEnumerator TextSet()
    {
        yield return new WaitForSeconds(1.0f);
        this.MessageText.GetComponent<Text>().text = "";
    }
}
