using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectEventTriggerPlayerEntry : MonoBehaviour
{
    public UnityEvent onTriggerEnter;
    public bool callDialogueBox;
    public int whichBox;
    public string[] dialogueLines;
    public int whenEventIsCalled;
    public UnityEvent onEventDialogue;
    private TextBoxManager textBoxManager;
    void Start()
    {
        textBoxManager = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<TextBoxManager>();
    }
    void OnTriggerEnter(Collider taggedObject)
    {
        if(taggedObject.tag == "Player")
        {
            onTriggerEnter.Invoke();
            if(callDialogueBox == true)
            {
                textBoxManager = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<TextBoxManager>();
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
}
