using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectNearbyObjects : MonoBehaviour
{
    //detecta gameObje
    public GameObject detectedGameObject;
    public string interactTag;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag != interactTag)
        {
            return;
        }
        detectedGameObject = other.gameObject;
        
    }
    void OnTriggerExit(Collider other)
    {
        detectedGameObject = null;
    }
    void OnTriggerStay(Collider other)
    {
        if(other.tag != interactTag)
        {
            return;
        }
        else
        {
            detectedGameObject = other.gameObject;
        }
    }
}
