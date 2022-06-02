using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressEnterToEvent : MonoBehaviour
{
    public bool active;
    //aperte enter e o evento sera chamado
    public UnityEvent eventToHappen;
    void Update()
    {
        if(active == true)
        {
            if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                eventToHappen.Invoke();
            }
        }
    }
    public void switchActive()
    {
        active = !active;
    }
}
