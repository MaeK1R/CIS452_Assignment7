/*
 * Matt Kirchoff
 * Move2.cs
 * CIS452 Assignment 7
 * move object for the command pattern
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace CIS452_Assignment7
{
    public class Move2 : MonoBehaviour
    {

        NavMeshAgent navMeshAgent;
        //public NavMeshAgent agent;


        public void Awake()
        {
            navMeshAgent = gameObject.GetComponent<NavMeshAgent>();

        }

        public Vector3 GetCurrentPosition()
        {
            return gameObject.transform.position;
        }
        public void MoveCommand2(Vector3 point)
        {
            //Debug.Log(point);
            navMeshAgent.SetDestination(point);
        }
    }
}

