using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CallAction : MonoBehaviour
{
    //coleçoes de funções para chamara ações espeficicas do jogo
    //aki é feito os dialogos do jogo, por enquanto
    private InventoryManager inventoryManager;
    private InfoKeeper infoKeeper;
    private TextBoxManager textBoxManager;
    public UnityEvent BookcaseDoorOpens;

    public UnityEvent rotateTable;
    public UnityEvent FireplaceDoorOpens;
    void Start()
    {
        inventoryManager = gameObject.GetComponent<InventoryManager>();
        infoKeeper = gameObject.GetComponent<InfoKeeper>();
        textBoxManager = gameObject.GetComponent<TextBoxManager>();
    }
//BOOKSTAND_PUZZLE---------------------------------------------------------------------------------------------------------------------------------------
    //estande de livros 1. Precisa colokar o livro dentro na estande de livro 3
    public void Puzzle_Bookstand_1()
    {
        if(infoKeeper.hasInvestigatedPuzzle_Bookcase_3 == false || infoKeeper.hasBookFromPuzzle_Bookcase_1 == true)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Alguns livros empoeirados estão dentros.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        if(infoKeeper.hasBookFromPuzzle_Bookcase_2 == false)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Alguns livros empoeirados de várias cores estão dentros.";
            textBoxManager.followUpText[1] = "* Um dos livros chama sua atenção. Ele é semelhante aos livros vermelhors anteriores. Você decide pega-lo.";
            textBoxManager.followUpText[2] = "* Você obteve um livro vermelho.";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasBookFromPuzzle_Bookcase_1 = true;
            return;
        }
        if(infoKeeper.hasBookFromPuzzle_Bookcase_2 == true)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Alguns livros empoeirados de várias cores estão dentros.";
            textBoxManager.followUpText[1] = "* Um dos livros chama sua atenção. Ele é outro livro vermelho.";
            textBoxManager.followUpText[2] = "* Você obteve um livro vermelho.";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasBookFromPuzzle_Bookcase_1 = true;
            return;
        }
        textBoxManager.followUpText[0] = "ERROR";
    }
    //estande de livros 2. Precisa colokar o livro dentro na estande 3
    public void Puzzle_Bookstand_2()
    {
        if(infoKeeper.hasInvestigatedPuzzle_Bookcase_3 == false || infoKeeper.hasBookFromPuzzle_Bookcase_2 == true)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Alguns livros empoeirados estão dentros.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        if(infoKeeper.hasBookFromPuzzle_Bookcase_1 == false)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Alguns livros empoeirados de várias cores estão dentros.";
            textBoxManager.followUpText[1] = "* Um dos livros chama sua atenção. Ele é semelhante aos livros vermelhors anteriores. Você decide pega-lo.";
            textBoxManager.followUpText[2] = "* Você obteve um Livro Vermelho.";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasBookFromPuzzle_Bookcase_2 = true;
            return;
        }
        if(infoKeeper.hasBookFromPuzzle_Bookcase_1 == true)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Alguns livros empoeirados de várias cores estão dentros.";
            textBoxManager.followUpText[1] = "* Um dos livros chama sua atenção. Ele é outro livro vermelho.";
            textBoxManager.followUpText[2] = "* Você obteve um Livro Vermelho.";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasBookFromPuzzle_Bookcase_2 = true;
            return;
        }
        textBoxManager.followUpText[0] = "ERROR";
        textBoxManager.turnOnDialogueBox();
    }
    //estande de livros 3. Tem que inserir os dois livros para continuar.
    public void Puzzle_Bookstand_3()
    {
        if(infoKeeper.hasInvestigatedPuzzle_Bookcase_3 == false)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Está repleta de livros vermelhos.";
            textBoxManager.followUpText[1] = "* Dois espaços vazios entre os livros chamam sua atenção.";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasInvestigatedPuzzle_Bookcase_3 = true;
            return;
        }
        if(infoKeeper.hasBookFromPuzzle_Bookcase_1 == true && infoKeeper.hasInsertedBook1 == false && infoKeeper.hasInsertedBook2 == false)
        {
            textBoxManager.followUpText[0] = "* Você preenche um dos espaços vazios com um livro vermelho.";
            textBoxManager.followUpText[1] = "* Você escuta um barulho na distancia.";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasInsertedBook1 = true;
            return;
        }
        if(infoKeeper.hasBookFromPuzzle_Bookcase_2 == true && infoKeeper.hasInsertedBook1 == false && infoKeeper.hasInsertedBook2 == false)
        {
            textBoxManager.followUpText[0] = "* Você preenche um dos espaços vazios com um livro vermelho.";
            textBoxManager.followUpText[1] = "* Você escuta um barulho na distancia.";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasInsertedBook2 = true;
            return;
        }
        if(infoKeeper.hasBookFromPuzzle_Bookcase_1 == true && infoKeeper.hasInsertedBook1 == false && infoKeeper.hasInsertedBook2 == true)
        {
            textBoxManager.followUpText[0] = "* Você preenche o último espaço vazio com um livro vermelho.";
            textBoxManager.followUpText[1] = "* Você escuta outro barulho na distancia.";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasInsertedBook1 = true;
            return;
        }
        if(infoKeeper.hasBookFromPuzzle_Bookcase_2 == true && infoKeeper.hasInsertedBook1 == true && infoKeeper.hasInsertedBook2 == false)
        {
            textBoxManager.followUpText[0] = "* Você preenche o último espaço vazio com um livro vermelho.";
            textBoxManager.followUpText[1] = "* Você escuta outro barulho na distancia.";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasInsertedBook2 = true;
            return;
        }
        if(infoKeeper.hasBookFromPuzzle_Bookcase_2 == true && infoKeeper.hasInsertedBook1 == true && infoKeeper.hasInsertedBook2 == true)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Está completamente repleta de livros vermelhos.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        if(infoKeeper.hasInsertedBook1 == true || infoKeeper.hasInsertedBook2 == true)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Aida está com um espaço vazio.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        if(infoKeeper.hasInsertedBook1 == false && infoKeeper.hasInsertedBook2 == false)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Está repleta de livros vermelhos.";
            textBoxManager.followUpText[1] = "* Dois espaços vazios entre os livros chamam sua atenção.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        textBoxManager.followUpText[0] = "ERROR";
        textBoxManager.turnOnDialogueBox();
    }
    public void Puzzle_Bookstand_Door()
    {
        if(infoKeeper.hasBookFromPuzzle_Bookcase_1 == true && infoKeeper.hasBookFromPuzzle_Bookcase_2 == true)
        {
            textBoxManager.followUpText[0] = "* Você empurra a porta.";
            textBoxManager.followUpText[1] = "* Ela abre!";
            textBoxManager.whenIsEventCalled = 1;
            textBoxManager.pendingEvent = BookcaseDoorOpens;
            textBoxManager.turnOnDialogueBox();
            return;
        }
        textBoxManager.followUpText[0] = "* Você empurra a porta, mas ela se recusa a abrir.";
        textBoxManager.turnOnDialogueBox();
    }
//FIREPLACE_PUZZLE-------------------------------------------------------------------------------------------------------------------------
    //estande 1
    public void Puzzle_Fireplace_Desk_1()
    {
        if(infoKeeper.hasPickedUpDeskClue1 == false && infoKeeper.hasBookFromPuzzle_Bookcase_2 == false)
        {
            textBoxManager.followUpText[0] = "Em cima da escrivania há um papel com algo escrito.";
            textBoxManager.followUpText[1] = "Na madeira que se concentra o fogo...";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasPickedUpDeskClue1 = true;
            return;
        }
        if(infoKeeper.hasPickedUpDeskClue1 == false && infoKeeper.hasBookFromPuzzle_Bookcase_2 == true)
        {
            textBoxManager.followUpText[0] = "Em cima da escrivania há outro papel com algo escrito.";
            textBoxManager.followUpText[1] = "...Escondida a chave está para a tumba alcançar.";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasPickedUpDeskClue1 = true;
            infoKeeper.DeskClue1HasBeenPickedSecond = true;
            return;
        }
        if(infoKeeper.DeskClue1HasBeenPickedSecond == true)
        {
            textBoxManager.followUpText[0] = "Em cima da escrivania há outro papel com algo escrito.";
            textBoxManager.followUpText[1] = "...Escondida a chave está para a tumba alcançar.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        if(infoKeeper.DeskClue1HasBeenPickedSecond == false)
        {
            textBoxManager.followUpText[0] = "Em cima da escrivania há um papel com algo escrito.";
            textBoxManager.followUpText[1] = "Na madeira que se concentra o fogo...";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        textBoxManager.followUpText[0] = "ERROR";
        textBoxManager.turnOnDialogueBox();
    }
    //estande 2
    public void Puzzle_Fireplace_Desk_2()
    {
        if(infoKeeper.hasPickedUpDeskClue2 == false && infoKeeper.hasBookFromPuzzle_Bookcase_1 == false)
        {
            textBoxManager.followUpText[0] = "Em cima da escrivania há um papel com algo escrito.";
            textBoxManager.followUpText[1] = "Na madeira que se concentra o fogo...";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasPickedUpDeskClue2 = true;
            return;
        }
        if(infoKeeper.hasPickedUpDeskClue2 == false && infoKeeper.hasBookFromPuzzle_Bookcase_1 == true)
        {
            textBoxManager.followUpText[0] = "Em cima da escrivania há outro papel com algo escrito.";
            textBoxManager.followUpText[1] = "...Escondida a chave está para a tumba alcançar.";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasPickedUpDeskClue2 = true;
            infoKeeper.DeskClue2HasBeenPickedSecond = true;
            return;
        }
        if(infoKeeper.DeskClue2HasBeenPickedSecond == true)
        {
            textBoxManager.followUpText[0] = "Em cima da escrivania há outro papel com algo escrito.";
            textBoxManager.followUpText[1] = "...Escondida a chave está para a tumba alcançar.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        if(infoKeeper.DeskClue2HasBeenPickedSecond == false)
        {
            textBoxManager.followUpText[0] = "Em cima da escrivania há um papel com algo escrito.";
            textBoxManager.followUpText[1] = "Na madeira que se concentra o fogo...";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        textBoxManager.followUpText[0] = "ERROR";
        textBoxManager.turnOnDialogueBox();
    }
    //lareira
    public void Puzzle_Fireplace()
    {
        if(infoKeeper.hasPickedUpDeskClue1 == false || infoKeeper.hasPickedUpDeskClue2 == false)
        {
            textBoxManager.followUpText[0] = "Uma lareira ornamental. Está apagada, porém ainda tem lenha dentro.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        if(infoKeeper.hasPickedChestKey == false)
        {
            textBoxManager.followUpText[0] = "Entre as peças de lenha há uma chave!";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        if(infoKeeper.hasPickedChestKey == true)
        {
            textBoxManager.followUpText[0] = "Uma lareira ornamental sem nenhuma chave.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        textBoxManager.followUpText[0] = "ERROR";
        textBoxManager.turnOnDialogueBox();
    }
    //estande de livro
    public void Puzzle_Fireplace_Bookstand()
    {
        if(infoKeeper.hasBookFromFireplacePuzzle == false)
        {
            textBoxManager.followUpText[0] = "Uma bela estande de livros amarelos. Parece estar faltando um.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        if(infoKeeper.hasBookFromFireplacePuzzle == true && infoKeeper.hasPlacedFireplaceBookInBookstand == false)
        {
            textBoxManager.followUpText[0] = "Aha! O livro cabe perfeitamente!";
            textBoxManager.followUpText[1] = "Eu ouvi um som na distancia. Algo deve ter acontecido.";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasPlacedFireplaceBookInBookstand = true;
            return;
        }
        if(infoKeeper.hasPlacedFireplaceBookInBookstand == true)
        {
            textBoxManager.followUpText[0] = "Uma estante completa de livros amarelos.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        textBoxManager.followUpText[0] = "ERROR";
        textBoxManager.turnOnDialogueBox();
    }
    //bau
    public void Puzzle_Fireplace_Chest()
    {
        if(infoKeeper.hasPickedChestKey == false)
        {
            textBoxManager.followUpText[0] = "Uma baú velho.";
            textBoxManager.followUpText[1] = "Hmph. Por mais que eu tente, eu não consigo abir.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        if(infoKeeper.hasBookFromFireplacePuzzle == false)
        {
            textBoxManager.followUpText[0] = "A chave que eu peguei da lareira cabe perfeitamente!";
            textBoxManager.followUpText[1] = "Dentro tem um livro amarelo!";
            textBoxManager.followUpText[2] = "Livro Amarelo adquirido!";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasBookFromFireplacePuzzle = true;
            return;
        }
        if(infoKeeper.hasBookFromFireplacePuzzle == true)
        {
            textBoxManager.followUpText[0] = "Nada mais para pegar aqui.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        textBoxManager.followUpText[0] = "ERROR";
        textBoxManager.turnOnDialogueBox();
    }
    public void Puzzle_Fireplace_Table()
    {
        if(infoKeeper.hasPlacedFireplaceBookInBookstand == false)
        {
            textBoxManager.followUpText[0] = "Uma simples mesa circular com três velas em cima. Estranhamente parece estar presa ao chão.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        if(infoKeeper.hasPlacedFireplaceBookInBookstand == true && infoKeeper.hasCheckedRotatingTable == false)
        {
            textBoxManager.followUpText[0] = "Uma simples mesa circular com três velas em cima.";
            textBoxManager.followUpText[1] = "Huh. Parece que ela poder rodada.";
            textBoxManager.whenIsEventCalled = 2;
            textBoxManager.pendingEvent = rotateTable;
            infoKeeper.hasCheckedRotatingTable = true;
            textBoxManager.turnOnDialogueBox();
            return;
        }
        if(infoKeeper.hasOpenedFireplaceDoor == true)
        {
            textBoxManager.followUpText[0] = "Uma rotatória mesa circular com três velas em cima.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        if(infoKeeper.hasOpenedFireplaceDoor == false)
        {
            textBoxManager.followUpText[0] = "Eu giro a mesa.";
            textBoxManager.whenIsEventCalled = 0;
            textBoxManager.pendingEvent = rotateTable;
            textBoxManager.turnOnDialogueBox();
            return;
        }
    }
    //eu vejo com o Luigi para integrar as cadeiras que movem no puzzle depois.
    public void Puzzle_Fireplace_Chair_1()
    {
        textBoxManager.followUpText[0] = "Essa cadeira parece estar presa no lugar.";
        textBoxManager.turnOnDialogueBox();
        return;
    }
    public void Puzzle_Fireplace_Chair_2()
    {
        textBoxManager.followUpText[0] = "Essa cadeira parece estar presa no lugar.";
        textBoxManager.turnOnDialogueBox();
        return;
    }
    public void Puzzle_Fireplace_Chair_3()
    {
        textBoxManager.followUpText[0] = "Essa cadeira parece estar presa no lugar.";
        textBoxManager.turnOnDialogueBox();
        return;
    }
    public void Puzzle_Fireplace_Door()
    {
        if(infoKeeper.tableRotation != 4)
        {
            textBoxManager.followUpText[0] = "Essa porta se recusa a abrir.";
            textBoxManager.turnOnDialogueBox();
            return;
        }
        if(infoKeeper.tableRotation == 4 && infoKeeper.hasOpenedFireplaceDoor == false)
        {
            textBoxManager.followUpText[0] = "Eu empurro na porta.";
            textBoxManager.followUpText[1] = "Ela abre!";
            textBoxManager.whenIsEventCalled = 1;
            textBoxManager.pendingEvent = FireplaceDoorOpens;
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasOpenedFireplaceDoor = true;
            return;
        }
    }
}
