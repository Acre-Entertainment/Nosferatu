using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CallableTimedEvents : MonoBehaviour
{
    public UnityEvent eventToHappen;
    public float timeUntilEvent;
    public void callEvent()
    {
        StartCoroutine(waitAndEvent());
    }
    void OnDisable()
    {
        StopCoroutine(waitAndEvent());
    }
    IEnumerator waitAndEvent()
    {
        yield return new WaitForSeconds(timeUntilEvent);
        eventToHappen.Invoke();
    }

}
