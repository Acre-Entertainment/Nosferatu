using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObjectEvent : MonoBehaviour
{
    //o evento do objeto a ser chamado. Isso deve estar localizado dentro de um objeto com colider e rigidbody
    public UnityEvent onInteraction;
    public bool callDialogueBox;
    public int[] whichBox = new int[20];
    public string[] dialogueLines;
    public int whenEventIsCalled;
    public UnityEvent onEventDialogue;
    protected TextBoxManager textBoxManager;
    
    public void callEvent()
    {
        textBoxManager = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<TextBoxManager>();
        onInteraction.Invoke();
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
