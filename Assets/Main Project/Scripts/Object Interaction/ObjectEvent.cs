using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectEvent : MonoBehaviour
{
    //o evento do objeto a ser chamado. Isso deve estar localizado dentro de um objeto com colider e rigidbody
    public UnityEvent onInteraction;
    public bool callDialogueBox;
    public string[] dialogueLines;
    //public int whenEventIsCalled;
    //public UnityEvent onEventDialogue;
}
