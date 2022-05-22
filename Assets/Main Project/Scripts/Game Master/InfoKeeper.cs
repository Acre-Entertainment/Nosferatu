using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoKeeper : MonoBehaviour
{
//Guarda variaveis para serem usadas por outros scripts.


//tecnico
    public bool gameIsBlockingInteraction = false;
    public bool playerIsHiding;
    public int nosferatuRoom;
    public void setNosferatuRoom(int room)
    {
        nosferatuRoom = room;
    }
    public int playerRoom = 1;
    public void setPlayerRoom(int room)
    {
        playerRoom = room;
    }

//tutorial
    public int test;
    public bool tutorialIsOver;
    public bool puzzleMulherPuraIsOver;
    public bool puzzle2IsOver;
    public bool puzzle3IsOver;
    public bool puzzle4IsOver;
    public bool puzzle5IsOver;
    public bool puzzle6IsOver;
    public bool tutorialHasPlayedRat;
    public bool tutorialHasCheckedDesk;

    public bool hasMulherPuraNote;
    public bool hasBookA, hasBookB, hasBookC, hasBookX, hasBookY, hasBookZ;
    public bool placedBookA_1, placedBookB_1, placedBookC_1, placedBookX_1, placedBookY_1, placedBookZ_1;
    public bool placedBookA_2, placedBookB_2, placedBookC_2, placedBookX_2, placedBookY_2, placedBookZ_2;

    public void ChangeBoolVariable(string variableName)
    {
        switch(variableName)
        {
            case "tutorialIsOver": tutorialIsOver = tutorialIsOver = true; break;
            case "puzzleMulherPuraIsOver": puzzleMulherPuraIsOver = puzzleMulherPuraIsOver = true; break;
            case "puzzle2IsOver": puzzle2IsOver = !puzzle2IsOver; break;
            case "puzzle3IsOver": puzzle3IsOver = !puzzle3IsOver; break;
            case "puzzle4IsOver": puzzle4IsOver = !puzzle4IsOver; break;
            case "puzzle5IsOver": puzzle5IsOver = !puzzle5IsOver; break;

            case "hasMulherPuraNote": hasMulherPuraNote = hasMulherPuraNote = true; break;
            case "hasBookA": hasBookA = !hasBookA; break;
            case "hasBookB": hasBookB = !hasBookB; break;
            case "hasBookC": hasBookC = !hasBookC; break;
            case "hasBookX": hasBookX = !hasBookX; break;
            case "hasBookY": hasBookY = !hasBookY; break;
            case "hasBookZ": hasBookZ = !hasBookZ; break;
            case "placedBookA_1": placedBookA_1 = !placedBookA_1; break;
            case "placedBookB_1": placedBookB_1 = !placedBookB_1; break;
            case "placedBookC_1": placedBookC_1 = !placedBookC_1; break;
            case "placedBookX_1": placedBookX_1 = !placedBookX_1; break;
            case "placedBookY_1": placedBookY_1 = !placedBookY_1; break;
            case "placedBookZ_1": placedBookZ_1 = !placedBookZ_1; break;
            case "placedBookA_2": placedBookA_2 = !placedBookA_2; break;
            case "placedBookB_2": placedBookB_2 = !placedBookB_2; break;
            case "placedBookC_2": placedBookC_2 = !placedBookC_2; break;
            case "placedBookX_2": placedBookX_2 = !placedBookX_2; break;
            case "placedBookY_2": placedBookY_2 = !placedBookY_2; break;
            case "placedBookZ_2": placedBookZ_2 = !placedBookZ_2; break;

            default: Debug.Log("InfoKeeper tentou mudar a variavel mas não deu certo."); break;
        }
    }



























//TEST STUFF -----------------------------------------------------------------------------------------------------------------------
    [HideInInspector] public bool hasInvestigatedPuzzle_Bookcase_3;
    [HideInInspector]public bool hasBookFromPuzzle_Bookcase_1;
    [HideInInspector]public bool hasBookFromPuzzle_Bookcase_2;
    [HideInInspector]public bool hasInsertedBook1;
    [HideInInspector]public bool hasInsertedBook2;
    [HideInInspector]public bool hasPickedUpDeskClue1;
    [HideInInspector]public bool DeskClue1HasBeenPickedSecond;
    [HideInInspector]public bool hasPickedUpDeskClue2;
    [HideInInspector]public bool DeskClue2HasBeenPickedSecond;
    [HideInInspector]public bool hasPickedChestKey;
    [HideInInspector]public bool hasBookFromFireplacePuzzle;
    [HideInInspector]public bool hasPlacedFireplaceBookInBookstand;
    [HideInInspector]public bool hasCheckedRotatingTable;
    [HideInInspector]public int tableRotation = 1;
    [HideInInspector]public bool chair1RightPlace;
    [HideInInspector]public bool chair2RightPlace;
    [HideInInspector]public bool chair3RightPlace;
    [HideInInspector]public bool hasOpenedFireplaceDoor;
    [HideInInspector]public bool hasInvestigatedSkeleton;
    [HideInInspector]public bool hasGottenFirstSkeletonChest;
    [HideInInspector]public bool hasGottenSecondSkeletonChest;
}
