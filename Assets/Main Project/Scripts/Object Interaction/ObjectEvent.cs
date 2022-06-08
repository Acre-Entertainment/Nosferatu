using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectEvent : MonoBehaviour
{
    //o evento do objeto a ser chamado. Isso deve estar localizado dentro de um objeto com colider e rigidbody
    public UnityEvent onInteraction;
    public bool callDialogueBox;
    public int whichBox;
    public string[] dialogueLines;
    public int whenEventIsCalled;
    public UnityEvent onEventDialogue;

    protected TextBoxManager textBoxManager;
    private void Start() {
        textBoxManager = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<TextBoxManager>();
    }
    public void callEvent()
    {
        onInteraction.Invoke();
        if(callDialogueBox == true)
        {
            textBoxManager.setWhichDialogue(whichBox);
            int x = 0;
            foreach(string y in dialogueLines)
                {
                    textBoxManager.followUpText[x] = y;
                    x++;
                }
            textBoxManager.pendingEvent = onEventDialogue;
            textBoxManager.whenIsEventCalled = whenEventIsCalled;
            textBoxManager.turnOnDialogueBox();
        }
    }
}
