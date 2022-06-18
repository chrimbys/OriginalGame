using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCounter : MonoBehaviour
{

    public int skeyCount;

    public int maxsKeyCount;

    private Text myKeyCountText;

    public int gKeyCount;

    public int maxgKeyCount;

    public bool KeyType;

    private GameObject image;

    public Sprite sprite2;

    // Start is called before the first frame update
    void Start()
    {
        this.myKeyCountText = GetComponent<Text>();
        image = GameObject.Find("Image");

        maxsKeyCount = GameObject.FindGameObjectsWithTag("TargetTag").Length;
        maxgKeyCount = GameObject.FindGameObjectsWithTag("GoalTag").Length;

        KeyType = false;
    }

    void UpdateSKeyCounter()
    {
        this.myKeyCountText.text = this.skeyCount + "/" + this.maxsKeyCount;


    }
    void UpdateGKeyCounter()
    {
        this.myKeyCountText.text = this.gKeyCount + "/" + this.maxgKeyCount;


    }
    // Update is called once per frame
    void Update()
    {
        if (KeyType == false)
        {
            UpdateSKeyCounter();
        }
        if (KeyType == true)
        {
            UpdateGKeyCounter();
            image.GetComponent<Image>().sprite = sprite2;
        }


    }

}

