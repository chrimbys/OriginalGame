using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class MoveController : MonoBehaviour
{
    private Animator myAnimator;

    private Rigidbody myRigidbody;

    private GameObject unitychan;

    private NavMeshAgent agent;

    void Start()
    {
        agent = GameObject.Find("unitychan").GetComponent<NavMeshAgent>();
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

        this.myAnimator.SetFloat("Speed", agent.velocity.sqrMagnitude);


    }

    private void MoveToCursor()
    {
        if (EventSystem.current.IsPointerOverGameObject()) return;
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            bool hasHit = Physics.Raycast(ray, out hit);
            if (hasHit)
            {
                GetComponent<NavMeshAgent>().destination = hit.point;
            }

        }


    }

}               