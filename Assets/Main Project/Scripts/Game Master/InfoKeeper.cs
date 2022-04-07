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

//Puzzle de Livros
    public bool hasInvestigatedPuzzle_Bookcase_3;
    public bool hasBookFromPuzzle_Bookcase_1;
    public bool hasBookFromPuzzle_Bookcase_2;
    public bool hasInsertedBook1;
    public bool hasInsertedBook2;
//Puzzle da Lareira
    public bool hasPickedUpDeskClue1;
    public bool DeskClue1HasBeenPickedSecond;
    public bool hasPickedUpDeskClue2;
      public bool DeskClue2HasBeenPickedSecond;
    public bool hasPickedChestKey;
    public bool hasBookFromFireplacePuzzle;
    public bool hasPlacedFireplaceBookInBookstand;
    public bool hasCheckedRotatingTable;
    public int tableRotation = 1;
    public bool chair1RightPlace;
    public bool chair2RightPlace;
    public bool chair3RightPlace;
    public bool hasOpenedFireplaceDoor;
    public bool hasInvestigatedSkeleton;
    public bool hasGottenFirstSkeletonChest;
    public bool hasGottenSecondSkeletonChest;
}
