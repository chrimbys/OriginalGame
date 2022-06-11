using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveController : MonoBehaviour
{
    private Animator myAnimator;

    private Rigidbody myRigidbody;

    private GameObject unitychan;



    void Start()
    {
        unitychan = GameObject.Find("unitychan");
        this.myAnimator = GetComponent<Animator>();


        this.myRigidbody = GetComponent<Rigidbody>();

        
    }



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            MoveToCursor();


        }



    }

    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);
        if (hasHit)
        {
            GetComponent<NavMeshAgent>().destination = hit.point;
        }

        this.myAnimator.SetFloat("Speed", 1);

        if (unitychan.transform.position == hit.point)
        {
            this.myAnimator.SetFloat("Speed", 0);
        }



    }

}               