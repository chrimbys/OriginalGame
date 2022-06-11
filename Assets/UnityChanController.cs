using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{
    private Animator myAnimator;

    private Rigidbody myRigidbody;



    // Start is called before the first frame update
    void Start()
    {
        this.myAnimator = GetComponent<Animator>();


        this.myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
