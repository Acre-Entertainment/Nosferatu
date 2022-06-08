using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAllObjectsWithScript : MonoBehaviour
{
    public PressEnterToEvent[] press;
    void Start()
    {
        press = (PressEnterToEvent[]) GameObject.FindObjectsOfType (typeof(PressEnterToEvent));
    }
}
