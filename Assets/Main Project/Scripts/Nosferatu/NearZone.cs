using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearZone : MonoBehaviour
{
    public bool playerIsInside;
    public bool targetIsInside;
    public NosferatuMovement nosferatuMovement;
    void OnEnable()
    {
        playerIsInside = false;
        targetIsInside = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            playerIsInside = true;
        }
        if(other == nosferatuMovement.currentTarget)
        {
            targetIsInside = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            playerIsInside = false;
        }
        if(other == nosferatuMovement.currentTarget)
        {
            targetIsInside = false;
        }
    }
}
