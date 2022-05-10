using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoKeeper : MonoBehaviour
{
//Guarda variaveis para serem usadas por outros scripts.


//tecnico
    public bool gameIsBlockingInteraction = false;
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
    public bool tutorialHasPlayedRat;





























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
