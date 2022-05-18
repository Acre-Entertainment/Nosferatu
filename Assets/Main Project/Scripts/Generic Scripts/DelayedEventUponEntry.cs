using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DelayedEventUponEntry : MonoBehaviour
{
    public float timeToHappen;
    public bool happenOnce;
    private bool blocking;
    public UnityEvent eventToHappen;
    public string objectTag;
    void OnTriggerEnter(Collider taggedObject)
    {
        if(taggedObject.tag == objectTag && blocking == false)
        {
            StartCoroutine(waitAndThenCallEvent());
        }
    }
    IEnumerator waitAndThenCallEvent()
    {
        yield return new WaitForSeconds(timeToHappen);
        eventToHappen.Invoke();
        if(happenOnce == true)
        {
            blocking = true;
        }
    }
}

