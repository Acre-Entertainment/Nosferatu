using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectedInteractableObjectTag : MonoBehaviour
{
    //Verifica a tag de um objeto por perto e a salva
    public string tagOfNearbyInteractableObject;
    void OnTriggerEnter(Collider other)
    {
        tagOfNearbyInteractableObject = other.tag;
    }
    void OnTriggerExit(Collider other)
    {
        tagOfNearbyInteractableObject = "";
    }
}