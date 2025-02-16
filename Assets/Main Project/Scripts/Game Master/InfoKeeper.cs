using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  InfoKeeper : MonoBehaviour
{
    //Guarda variaveis para serem usadas por outros scripts.

    public bool playerIsDead = false;


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
    public bool tutorialIsOver;
    public bool puzzleMulherPuraIsOver;
    public bool puzzleComoMataOver;
    public bool puzzleOndeDormeIsOver;
    public bool puzzleRatosAmigosIsOver;
    public bool puzzleOQueComeIsOver;
    
    public bool tutorialHasPlayedRat;
    public bool tutorialHasCheckedDesk;

    public bool hasMulherPuraNote;
    public bool hasBookA, hasBookB, hasBookC, hasBookX, hasBookY, hasBookZ;
    public bool placedBookA_1, placedBookB_1, placedBookC_1, placedBookX_1, placedBookY_1, placedBookZ_1;
    public bool placedBookA_2, placedBookB_2, placedBookC_2, placedBookX_2, placedBookY_2, placedBookZ_2;

    public int castInventory;
    public int bookInventory;

    public bool hasMataMetalBox, metalBoxIn1, metalBoxIn2, metalBoxIn3;
    public bool hasMataWoodBox, woodBoxIn1, woodBoxIn2, woodBoxIn3;
    public bool hasMataClayBox, clayBoxIn1, clayBoxIn2, clayBoxIn3;
    public bool hasMataBroom;
    public bool hasMataBook;
    public bool hasMataOpenedDoor;

    public bool hasDormeKey1, hasDormeKey2, hasDormeKey3, hasDormeKey4, hasDormeKey5;

    public int ratoTablePosition1, ratoTablePosition2, ratoTablePosition3;
    public bool hasRatoKey1, hasRatoKey2;

    public void ChangeBoolVariable(string variableName)
    {
        switch(variableName)
        {
            case "tutorialIsOver": tutorialIsOver = true; break;
            case "puzzleMulherPuraIsOver": puzzleMulherPuraIsOver = true; break;
            case "puzzleComoMataOver": puzzleComoMataOver = true; break;
            case "puzzleOndeDormeIsOver": puzzleOndeDormeIsOver = true; break;
            case "puzzleRatosAmigosIsOver": puzzleRatosAmigosIsOver = true; break;
            case "puzzleOQueComeIsOver": puzzleOQueComeIsOver = true; break;

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

            case "hasMataMetalBox": hasMataMetalBox = !hasMataMetalBox; break;
            case "hasMataWoodBox": hasMataWoodBox = !hasMataWoodBox; break;
            case "hasMataClayBox": hasMataClayBox = !hasMataClayBox; break;
            case "metalBoxIn1": metalBoxIn1 = !metalBoxIn1; break;
            case "metalBoxIn2": metalBoxIn2 = !metalBoxIn2; break;
            case "metalBoxIn3": metalBoxIn3 = !metalBoxIn3; break;
            case "woodBoxIn1": woodBoxIn1 = !woodBoxIn1; break;
            case "woodBoxIn2": woodBoxIn2 = !woodBoxIn2; break;
            case "woodBoxIn3": woodBoxIn3 = !woodBoxIn3; break;
            case "clayBoxIn1": clayBoxIn1 = !clayBoxIn1; break;
            case "clayBoxIn2": clayBoxIn2 = !clayBoxIn2; break;
            case "clayBoxIn3": clayBoxIn3 = !clayBoxIn3; break;

            case "hasMataBroom": hasMataBroom = !hasMataBroom; break;
            case "hasMataBook": hasMataBook = !hasMataBook; break;
            case "hasMataOpenedDoor": hasMataOpenedDoor = !hasMataOpenedDoor; break;
            
            case "hasDormeKey1": hasDormeKey1 = !hasDormeKey1; break;
            case "hasDormeKey2": hasDormeKey2 = !hasDormeKey2; break;
            case "hasDormeKey3": hasDormeKey3 = !hasDormeKey3; break;
            case "hasDormeKey4": hasDormeKey4 = !hasDormeKey4; break;
            case "hasDormeKey5": hasDormeKey5 = !hasDormeKey5; break;

            case "ratoTablePosition1": ratoTablePosition1++; if(ratoTablePosition1 > 4){ratoTablePosition1 = 1;} break;
            case "ratoTablePosition2": ratoTablePosition2++; if(ratoTablePosition2 > 4){ratoTablePosition2 = 1;} break;
            case "ratoTablePosition3": ratoTablePosition3++; if(ratoTablePosition3 > 4){ratoTablePosition3 = 1;} break;
            case "hasRatoKey1": hasRatoKey1 = !hasRatoKey1; break;
            case "hasRatoKey2": hasRatoKey2 = !hasRatoKey2; break;

            default: Debug.Log(" tentou mudar a variavel mas não deu certo."); break;
        }
    }

    public void PlayerIsDead()
    {
        playerIsDead = true;
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
