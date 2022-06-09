using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectEventTriggerPlayerEntry : MonoBehaviour
{
    public UnityEvent onTriggerEnter;
    public bool callDialogueBox;
    public int[] whichBox;
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
                int x = 0;
                foreach(string y in dialogueLines)
                    {
                        textBoxManager.followUpText[x] = y;
                        x++;
                    }
                x = 0;
                if(whichBox.Length > 0)
                {
                    foreach(int z in whichBox)
                    {
                        textBoxManager.followUpBox[x] = z;
                        x++;
                    }
                }
                else
                {
                    textBoxManager.setWhichDialogue(0);

                    foreach(int z in textBoxManager.followUpBox)
                    {
                        textBoxManager.followUpBox[x] = 0;
                        x++;
                    }
                }


                textBoxManager.pendingEvent = onEventDialogue;
                textBoxManager.whenIsEventCalled = whenEventIsCalled;
                textBoxManager.turnOnDialogueBox();
            }
        }
    }
}
