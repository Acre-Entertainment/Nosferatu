using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorText : ObjectEvent
{
    public static bool callDialogueBoxOnPuzzleSolved;
    public string[] dialogueLinesOnPuzzleSolved;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (callDialogueBoxOnPuzzleSolved == true)
        {
            int x = 0;
            foreach (string y in dialogueLinesOnPuzzleSolved)
            {
                textBoxManager.followUpText[x] = y;
                x++;
            }
            textBoxManager.turnOnDialogueBox();
        }
    }

    public void CallDialogue()
    {
        callDialogueBoxOnPuzzleSolved = true;
    }
}
