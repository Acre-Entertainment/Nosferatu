using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressureButton : MonoBehaviour
{
    public string activatorTag;
    public UnityEvent onEntering;
    public UnityEvent onEmpty;
    private bool somethingIsOn;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == activatorTag)
        {
            onEntering.Invoke();
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.tag == activatorTag)
        {
            onEmpty.Invoke();
        }
    }
}
