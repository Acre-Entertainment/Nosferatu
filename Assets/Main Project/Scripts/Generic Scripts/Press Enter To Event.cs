using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressEnterToEvent : MonoBehaviour
{
    //aperte enter e o evento sera chamado
    public UnityEvent eventToHappen;
    void update()
    {
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            eventToHappen.Invoke();
        }
    }
}
