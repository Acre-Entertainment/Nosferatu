using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallAction : MonoBehaviour
{
    //coleçoes de funções para chamara ações espeficicas do jogo
    //aki é feito os dialogos do jogo, por enquanto
    private InventoryManager inventoryManager;
    private InfoKeeper infoKeeper;
    private TextBoxManager textBoxManager;
    void Start()
    {
        inventoryManager = gameObject.GetComponent<InventoryManager>();
        infoKeeper = gameObject.GetComponent<InfoKeeper>();
        textBoxManager = gameObject.GetComponent<TextBoxManager>();
    }
    public void Puzzle_Bookstand_1()
    {
        if(infoKeeper.hasInvestigatedPuzzle_Bookcase_3 == false || infoKeeper.hasBookFromPuzzle_Bookcase_1 == true)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Alguns livros empoeirados estão dentros.";
            textBoxManager.callnextText();
            return;
        }
        if(infoKeeper.hasBookFromPuzzle_Bookcase_2 == false)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Alguns livros empoeirados estão dentros.";
            textBoxManager.followUpText[1] = "* Um dos livros chama sua atenção. Ele é semelhante aos livros vermelhors anteriores. Você decide pega-lo.";
            textBoxManager.followUpText[2] = "* Você obteve um livro vermelho.";
            textBoxManager.callnextText();
            infoKeeper.hasBookFromPuzzle_Bookcase_1 = true;
            return;
        }
        if(infoKeeper.hasBookFromPuzzle_Bookcase_2 == true)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Alguns livros empoeirados estão dentros.";
            textBoxManager.followUpText[1] = "* Um dos livros chama sua atenção. Ele é outro livro vermelho.";
            textBoxManager.followUpText[2] = "* Você obteve um livro vermelho.";
            textBoxManager.callnextText();
            infoKeeper.hasBookFromPuzzle_Bookcase_1 = true;
            return;
        }
        textBoxManager.followUpText[0] = "ERROR";
    }
    public void Puzzle_Bookstand_2()
    {
        if(infoKeeper.hasInvestigatedPuzzle_Bookcase_3 == false || infoKeeper.hasBookFromPuzzle_Bookcase_2 == true)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Alguns livros empoeirados estão dentros.";
            textBoxManager.callnextText();
            return;
        }
        if(infoKeeper.hasBookFromPuzzle_Bookcase_1 == false)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Alguns livros empoeirados estão dentros.";
            textBoxManager.followUpText[1] = "* Um dos livros chama sua atenção. Ele é semelhante aos livros vermelhors anteriores. Você decide pega-lo.";
            textBoxManager.followUpText[2] = "* Você obteve um livro vermelho.";
            textBoxManager.callnextText();
            infoKeeper.hasBookFromPuzzle_Bookcase_2 = true;
            return;
        }
        if(infoKeeper.hasBookFromPuzzle_Bookcase_1 == true)
        {
            textBoxManager.followUpText[0] = "* Uma bela estante de livros. Alguns livros empoeirados estão dentros.";
            textBoxManager.followUpText[1] = "* Um dos livros chama sua atenção. Ele é outro livro vermelho.";
            textBoxManager.followUpText[2] = "* Você obteve um livro vermelho.";
            textBoxManager.callnextText();
            infoKeeper.hasBookFromPuzzle_Bookcase_2 = true;
            return;
        }
        textBoxManager.followUpText[0] = "ERROR";
    }
    public void Puzzle_Bookstand_3()
    {

    }
    public void Puzzle_Bookstand_Door()
    {

    }
}
