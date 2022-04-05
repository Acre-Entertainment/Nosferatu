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
    [HideInInspector] UnityEvent pendingEventCallInTextManager;
    public UnityEvent BookcaseDoorOpens;
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
            textBoxManager.followUpText[2] = "* Você obteve um livro vermelho.";
            textBoxManager.turnOnDialogueBox();
            infoKeeper.hasBookFromPuzzle_Bookcase_2 = true;
            return;
        }
        if(infoKeeper.hasBookFromPuzzle_Bookcase_1 == true)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Alguns livros empoeirados de várias cores estão dentros.";
            textBoxManager.followUpText[1] = "* Um dos livros chama sua atenção. Ele é outro livro vermelho.";
            textBoxManager.followUpText[2] = "* Você obteve um livro vermelho.";
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
}
