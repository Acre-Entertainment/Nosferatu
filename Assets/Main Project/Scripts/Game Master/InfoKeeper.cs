using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoKeeper : MonoBehaviour
{
//Guarda variaveis para serem usadas por outros scripts.

//tecnico
    public bool gameIsBlockingInteraction = false;

//Puzzle de Livros
    public bool hasInvestigatedPuzzle_Bookcase_3;
    public bool hasBookFromPuzzle_Bookcase_1;
    public bool hasBookFromPuzzle_Bookcase_2;
    public bool hasInsertedBook1;
    public bool hasInsertedBook2;
//Puzzle da Lareira
    public bool hasPickedUpDeskClue1;
    public bool hasPickedUpDeskClue2;
    public bool hasFinishedFireplaceNumberCrack;
}
