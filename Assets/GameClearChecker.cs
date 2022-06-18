using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClearChecker : MonoBehaviour
{

    private KeyCounter keyCounter;



    // Start is called before the first frame update
    void Start()
    {
        keyCounter = GameObject.Find("KeyCounter").GetComponent<KeyCounter>();
    }

    void OnclickDoor()
    {
        if (keyCounter.gKeyCount == keyCounter.maxgKeyCount)
        {
            Debug.Log("Clear");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
