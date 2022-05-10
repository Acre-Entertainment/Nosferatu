using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectEventTriggerPlayerEntry : MonoBehaviour
{
    public UnityEvent onTriggerEnter;
    public bool callDialogueBox;
    public string[] dialogueLines;
    public int whenEventIsCalled;
    public UnityEvent onEventDialogue;
    private TextBoxManager textBoxManager;
    void OnTriggerEnter(Collider taggedObject)
    {
        if(taggedObject.tag == "Player")
        {
            onTriggerEnter.Invoke();
            if(callDialogueBox == true)
            {
                textBoxManager = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<TextBoxManager>();
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
}
