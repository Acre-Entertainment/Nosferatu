using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DetectNearbyObjects : MonoBehaviour
{
    //detecta gameObje
    public GameObject detectedGameObject;
    public string interactTag;
    public UnityEvent onObjectEnter;
    public UnityEvent onObjectLeave;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == interactTag)
        {
            detectedGameObject = other.gameObject;
            onObjectEnter.Invoke();
        }
    }
    void OnTriggerExit(Collider other)
    {
        detectedGameObject = null;
        onObjectLeave.Invoke();
    }
    void OnTriggerStay(Collider other)
    {
        if(other.tag == interactTag)
        {
            detectedGameObject = other.gameObject;
            onObjectEnter.Invoke();
        }
    }
}
