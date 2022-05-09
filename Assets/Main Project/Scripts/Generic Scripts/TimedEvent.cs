using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimedEvent : MonoBehaviour
{
    //apos o GameObject ser ativado, espera um tempo e então ativa o event;
    public UnityEvent eventToHappen;
    public float timeUntilEvent;
    void OnEnable()
    {

    }
    IEnumerator waitAndEvent()
    {
        yield return new WaitForSeconds(timeUntilEvent);
        eventToHappen.Invoke();
    }

}
