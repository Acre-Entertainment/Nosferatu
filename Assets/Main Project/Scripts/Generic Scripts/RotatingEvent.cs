using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RotatingEvent : MonoBehaviour
{
    public float timePulse;
    public UnityEvent unityEvent;

    void Start()
    {
        StartCoroutine(routine());
    }

    IEnumerator routine()
    {
        while(true)
        {
            yield return new WaitForSeconds(timePulse);
            unityEvent.Invoke();
        }
    }
}
