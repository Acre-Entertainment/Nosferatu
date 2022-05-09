using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightZone : MonoBehaviour
{
    public GameObject player;
    public bool playerIsInside;
    public bool nosferatuHasLineOfSight;
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
    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            playerIsInside = true;
        }
        else
        {
            playerIsInside = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            playerIsInside = false;
        }
    }
    void Update()
    {
        if(playerIsInside == true)
        {

        }
    }

}