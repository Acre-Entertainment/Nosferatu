using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearZone : MonoBehaviour
{
    public bool playerIsInside;
    void OnEnable()
    {
        playerIsInside = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerIsInside = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            playerIsInside = false;
        }
    }
}
