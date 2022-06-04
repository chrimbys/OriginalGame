using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanController : MonoBehaviour
{
    private Animator myAnimator;

    private Rigidbody myRigidbody;

    private float velocityZ = 5f;

    private float coefficient = 2f;

    // Start is called before the first frame update
    void Start()
    {
        this.myAnimator = GetComponent<Animator>();


        this.myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {


            this.myRigidbody.velocity = new Vector3(0, 0, velocityZ);

            this.myAnimator.SetFloat("Speed", 1);

        }

        if(Input.GetKeyUp(KeyCode.W))
        {
            this.velocityZ *= this.coefficient;
            this.myAnimator.SetFloat("Speed", 0);
        }
    }
}
