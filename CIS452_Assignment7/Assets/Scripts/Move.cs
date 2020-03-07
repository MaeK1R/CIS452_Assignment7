/*
 * Matt Kirchoff
 * Move.cs
 * CIS452 Assignment 7
 * Move object for command pattern
 */
 using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;

namespace CIS452_Assignment7
{
    public class Move : MonoBehaviour
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


        public void MoveCommand(Vector3 point)
        {
            //Debug.Log(point);
            navMeshAgent.SetDestination(point);
        }



    }
}