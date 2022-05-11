using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TutorialPlateDoor : ObjectEvent
{
    public UnityEvent onInteractionOther;
    UnityEvent onInteractionTemp;
    public bool callDialogueBoxOther;
    bool callDialogueBoxTemp;
    public string[] dialogueLinesOther;
    string[] dialogueLinesTemp;
    public TutorialWallPlatePuzzle tutorialWallPlatePuzzle;
    bool puzzleIsSolved;
    public void checkPuzzle()
    {
        if(tutorialWallPlatePuzzle.plate2Position == 2 && tutorialWallPlatePuzzle.plate3Position == 2 && tutorialWallPlatePuzzle.plate4Position == 2 && puzzleIsSolved == false)
        {
            puzzleIsSolved = true;
            replace();
        }
        if(tutorialWallPlatePuzzle.plate2Position != 2 || tutorialWallPlatePuzzle.plate3Position != 2 || tutorialWallPlatePuzzle.plate4Position != 2 && puzzleIsSolved == true)
        {
            puzzleIsSolved = false;
            replace();
        }
    }
    public void replace()
    {
        onInteractionTemp = onInteraction;
        onInteraction = onInteractionOther;
        onInteractionOther = onInteractionTemp;

        callDialogueBoxTemp = callDialogueBox;
        callDialogueBox = callDialogueBoxOther;
        callDialogueBoxOther = callDialogueBoxTemp;

        dialogueLinesTemp = dialogueLines;
        dialogueLines = dialogueLinesOther;
        dialogueLinesOther = dialogueLinesTemp;
    }
}
