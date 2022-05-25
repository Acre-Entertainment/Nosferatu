using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TutorialPlateDoor : ObjectEvent
{
    public UnityEvent onPuzzleSolved;
    public bool callDialogueBoxOnPuzzleSolved;
    public string[] dialogueLinesOnPuzzleSolved;
    public TutorialWallPlatePuzzle tutorialWallPlatePuzzle;
    bool puzzleIsSolved;
    public void checkPuzzle()
    {
        if(tutorialWallPlatePuzzle.plate2Position == 2 && tutorialWallPlatePuzzle.plate3Position == 2 && tutorialWallPlatePuzzle.plate4Position == 2 && tutorialWallPlatePuzzle.preassurePlateIsPressed == true  && puzzleIsSolved == false)
        {
            puzzleIsSolved = true;
            onPuzzleSolved.Invoke();
            if(callDialogueBoxOnPuzzleSolved == true)
            {
                int x = 0;
                foreach(string y in dialogueLinesOnPuzzleSolved)
                {
                    textBoxManager.followUpText[x] = y;
                    x++;
                }
                textBoxManager.turnOnDialogueBox();
            }
            //replace();
        }
        if((tutorialWallPlatePuzzle.plate2Position != 2 || tutorialWallPlatePuzzle.plate3Position != 2 || tutorialWallPlatePuzzle.plate4Position != 2 || tutorialWallPlatePuzzle == false) && puzzleIsSolved == true)
        {
            puzzleIsSolved = false;
            //replace();
        }
    }
    //public void replace()
    //{
    //    onInteractionTemp = onInteraction;
    //    onInteraction = onInteractionOther;
    //    onInteractionOther = onInteractionTemp;

    //    callDialogueBoxTemp = callDialogueBox;
    //    callDialogueBox = callDialogueBoxOther;
    //    callDialogueBoxOther = callDialogueBoxTemp;

    //    dialogueLinesTemp = dialogueLines;
    //    dialogueLines = dialogueLinesOther;
    //    dialogueLinesOther = dialogueLinesTemp;
    //}
}
