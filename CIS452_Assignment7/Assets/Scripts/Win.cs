/*
 * Matt Kirchoff
 * Win.cs
 * CIS452 Assignment 7
 * checks win conditions
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public List<GameObject> targets;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(targets.Count > 1)
        {
            Debug.Log("win");
            SceneManager.LoadScene(1);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("one");
            targets.Add(other.gameObject);
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        {
            Debug.Log("one");
            targets.Remove(other.gameObject);
        }
    }
}
