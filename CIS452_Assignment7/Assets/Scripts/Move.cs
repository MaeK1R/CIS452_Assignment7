using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move
{
    
    public static NavMeshAgent agent;

    public static List<Vector3> locations;
    void Start()
    {
        agent = GameObject.FindGameObjectWithTag("Player").GetComponent<NavMeshAgent>();
    }
    public static void MovePlayer(Vector3 vector3)
    {
        agent.SetDestination(vector3);
        locations = new List<Vector3>();
    }

    public static void Rewind(Vector3 vector3)
    {
        for (int i = 0; i < locations.Count; i++)
        {
            if(locations[i] == vector3)
            {
                agent.SetDestination(vector3);
                locations.RemoveAt(i);
                break;
            }
        }
    }
}
