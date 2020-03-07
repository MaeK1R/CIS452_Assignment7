/*
 * Matt Kirchoff
 * CamFollow.cs
 * CIS452 Assignment 7
 * Previously used camera behavior (not in game)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public bool followPlayer = true;
    public GameObject target1;
    public GameObject target2;
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 10f;
    private Vector3 lastPos = Vector3.zero;
    public float distBetween;
    public static bool undo;
    private void Awake()
    {
        lastPos = transform.position;
    }
    void FixedUpdate()
    {
        FollowCheck();
        FollowTarget();
        Follow();
        Undo();

        if (Input.GetKey(KeyCode.R))
            undo = true;
        else
            undo = false;
            
    //Debug.Log("Target dist z:  " + (target1.transform.position.z - target2.transform.position.z));
}
    void FollowTarget()
    {
        if (target1.transform.position.z > target2.transform.position.z)
        {
            target = target1.transform;
        }
        else
        {
            target = target2.transform;
        }
    }
    void Follow()
    {
        if (followPlayer && (target.position - lastPos).z > 0 && !undo)
        {
            Vector3 desiredPosition = new Vector3(6.8f, -140f, target.position.z) + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
            lastPos = transform.position;
        }
    }
    void FollowCheck()
    {
        if ((target1.transform.position.z > (distBetween + target2.transform.position.z) || target1.transform.position.z < (distBetween - target2.transform.position.z)) || (target2.transform.position.z > (distBetween + target1.transform.position.z) || target2.transform.position.z < (distBetween - target1.transform.position.z)))
        {
            Debug.Log("Dist too large");
            followPlayer = false;
        }
        else
        {
            followPlayer = true;
        }
    }
    void Undo()
    {
        if (undo)
        {
            Vector3 desiredPosition = new Vector3(6.8f, -140f, target.position.z) + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
            transform.position = smoothedPosition;
            lastPos = transform.position;
        }
    }
    
}
