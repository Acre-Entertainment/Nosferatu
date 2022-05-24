using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PublicEvent : MonoBehaviour
{
    public UnityEvent unityEvent;

    public void callPublicEvent()
    {
        unityEvent.Invoke();
    }
}
