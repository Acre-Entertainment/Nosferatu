using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PressEnterToEvent : MonoBehaviour
{
    private bool blockFirstFrame;
    //aperte enter e o evento sera chamado
    public UnityEvent eventToHappen;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            //Debug.Log("This POS is " + gameObject);
            eventToHappen.Invoke();
        }
    }
}
