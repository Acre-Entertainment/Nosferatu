using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Unhide : MonoBehaviour
{
    //desativa o joagdor estar se escondendo. O gameobject que se econtra deve estar desativado se o joagdor n estiver escondendo
    //provalvemente vou mudar como funciona isso apos o J1
    public UnityEvent onUnhide;
    void Update()
    {
        //pode mudar o botão pra se desesconder aki
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            onUnhide.Invoke();
        }
    }
}