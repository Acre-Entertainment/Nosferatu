using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectedInteractableObjectTag : MonoBehaviour
{
    //Verifica a tag de um objeto por perto e a salva
    public string tagOfNearbyInteractableObject;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            return;
        }
        tagOfNearbyInteractableObject = other.tag;
        
    }
    void OnTriggerExit(Collider other)
    {
        tagOfNearbyInteractableObject = "";
    }
    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            return;
        }
        else
        {
            tagOfNearbyInteractableObject = other.tag;
        }
    }
}