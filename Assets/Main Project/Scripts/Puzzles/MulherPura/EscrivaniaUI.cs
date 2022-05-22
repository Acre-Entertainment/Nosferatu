using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EscrivaniaUI : MonoBehaviour
{
    InfoKeeper infoKeeper;
    public int qualEscrivania;
    public string bookAName, bookBName, bookCName, bookXName, bookYName, bookZName;
    public GameObject button1, button2, button3, button4, button5, button6, otherButton1, otherButton2, otherButton3;
    public TextMeshProUGUI text1, text2, text3, text4, text5, text6, otherText1, otherText2, otherText3;
    TextMeshProUGUI[] buttonsText = new TextMeshProUGUI[6];
    TextMeshProUGUI[] otherButtonsText = new TextMeshProUGUI[3];
    GameObject[] buttons = new GameObject[6];
    GameObject[] otherButtons = new GameObject[3];
    string button1Book, button2Book, button3Book, button4Book, button5Book, button6Book;
    string[] buttonBooks = new string[6];
    public string[] currentBooksInTheTable = new string[3];
    int quantityOfBooksInTheTable;
    private void Awake() {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
        Time.timeScale = 0;
        buttons[0] = button1;
        buttons[1] = button2;
        buttons[2] = button3;
        buttons[3] = button4;
        buttons[4] = button5;
        buttons[5] = button6;
        otherButtons[0] = otherButton1;
        otherButtons[1] = otherButton2;
        otherButtons[2] = otherButton3;
        buttonsText[0] = text1;
        buttonsText[1] = text2;
        buttonsText[2] = text3;
        buttonsText[3] = text4;
        buttonsText[4] = text5;
        buttonsText[5] = text6;
        otherButtonsText[0] = otherText1;
        otherButtonsText[1] = otherText2;
        otherButtonsText[2] = otherText3;
    }
    private void OnEnable(){
        resetButtons();
        Time.timeScale = 0;
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void resetButtons()
    {
        if(currentBooksInTheTable[1] == null || currentBooksInTheTable[1] == "")
        {
            currentBooksInTheTable[1] = currentBooksInTheTable[2];
            currentBooksInTheTable[2] = "";
        }
        if(currentBooksInTheTable[0] == null || currentBooksInTheTable[0] == "")
        {
            currentBooksInTheTable[0] = currentBooksInTheTable[1];
            currentBooksInTheTable[1] = "";
        }

        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);
        otherButton1.SetActive(false);
        otherButton2.SetActive(false);
        otherButton3.SetActive(false);

        int x = 0;
        if(infoKeeper.hasBookA == true){buttonBooks[x] = "A"; buttonsText[x].text = bookAName; buttons[x].SetActive(true); x++;}
        if(infoKeeper.hasBookB == true){buttonBooks[x] = "B"; buttonsText[x].text = bookBName; buttons[x].SetActive(true); x++;}
        if(infoKeeper.hasBookC == true){buttonBooks[x] = "C"; buttonsText[x].text = bookCName; buttons[x].SetActive(true); x++;}
        if(infoKeeper.hasBookX == true){buttonBooks[x] = "X"; buttonsText[x].text = bookXName; buttons[x].SetActive(true); x++;}
        if(infoKeeper.hasBookY == true){buttonBooks[x] = "Y"; buttonsText[x].text = bookYName; buttons[x].SetActive(true); x++;}
        if(infoKeeper.hasBookZ == true){buttonBooks[x] = "Z"; buttonsText[x].text = bookZName; buttons[x].SetActive(true); x++;}

        if(qualEscrivania == 1)
        {
            x = 0;
            quantityOfBooksInTheTable = 0;
            if(infoKeeper.placedBookA_1 == true && quantityOfBooksInTheTable < 3){otherButtonsText[x].text = currentBooksInTheTable[x]; otherButtons[x].SetActive(true); x++; quantityOfBooksInTheTable++;}
            if(infoKeeper.placedBookB_1 == true && quantityOfBooksInTheTable < 3){otherButtonsText[x].text = currentBooksInTheTable[x]; otherButtons[x].SetActive(true); x++; quantityOfBooksInTheTable++;}
            if(infoKeeper.placedBookC_1 == true && quantityOfBooksInTheTable < 3){otherButtonsText[x].text = currentBooksInTheTable[x]; otherButtons[x].SetActive(true); x++; quantityOfBooksInTheTable++;}
            if(infoKeeper.placedBookX_1 == true && quantityOfBooksInTheTable < 3){otherButtonsText[x].text = currentBooksInTheTable[x]; otherButtons[x].SetActive(true); x++; quantityOfBooksInTheTable++;}
            if(infoKeeper.placedBookY_1 == true && quantityOfBooksInTheTable < 3){otherButtonsText[x].text = currentBooksInTheTable[x]; otherButtons[x].SetActive(true); x++; quantityOfBooksInTheTable++;}
            if(infoKeeper.placedBookZ_1 == true && quantityOfBooksInTheTable < 3){otherButtonsText[x].text = currentBooksInTheTable[x]; otherButtons[x].SetActive(true); x++; quantityOfBooksInTheTable++;}
        }
        if(qualEscrivania == 2)
        {
            x = 0;
            quantityOfBooksInTheTable = 0;
            if(infoKeeper.placedBookA_2 == true && quantityOfBooksInTheTable < 3){otherButtonsText[x].text = currentBooksInTheTable[x]; otherButtons[x].SetActive(true); x++; quantityOfBooksInTheTable++;}
            if(infoKeeper.placedBookB_2 == true && quantityOfBooksInTheTable < 3){otherButtonsText[x].text = currentBooksInTheTable[x]; otherButtons[x].SetActive(true); x++; quantityOfBooksInTheTable++;}
            if(infoKeeper.placedBookC_2 == true && quantityOfBooksInTheTable < 3){otherButtonsText[x].text = currentBooksInTheTable[x]; otherButtons[x].SetActive(true); x++; quantityOfBooksInTheTable++;}
            if(infoKeeper.placedBookX_2 == true && quantityOfBooksInTheTable < 3){otherButtonsText[x].text = currentBooksInTheTable[x]; otherButtons[x].SetActive(true); x++; quantityOfBooksInTheTable++;}
            if(infoKeeper.placedBookY_2 == true && quantityOfBooksInTheTable < 3){otherButtonsText[x].text = currentBooksInTheTable[x]; otherButtons[x].SetActive(true); x++; quantityOfBooksInTheTable++;}
            if(infoKeeper.placedBookZ_2 == true && quantityOfBooksInTheTable < 3){otherButtonsText[x].text = currentBooksInTheTable[x]; otherButtons[x].SetActive(true); x++; quantityOfBooksInTheTable++;}
        }
        if(qualEscrivania != 1 && qualEscrivania != 2)
        {
            Debug.Log("Não definiu a escrivania");
        }
        if(quantityOfBooksInTheTable == 3)
        {
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            button4.SetActive(false);
            button5.SetActive(false);
            button6.SetActive(false);
        }
    }
    public void pressedButton(int but)
    {
        switch(but)
        {
            case 1: currentBooksInTheTable[quantityOfBooksInTheTable] = buttonBooks[0]; setInfoKeeperRemoveBook(buttonBooks[0]);  break;
            case 2: currentBooksInTheTable[quantityOfBooksInTheTable] = buttonBooks[1]; setInfoKeeperRemoveBook(buttonBooks[1]);  break;
            case 3: currentBooksInTheTable[quantityOfBooksInTheTable] = buttonBooks[2]; setInfoKeeperRemoveBook(buttonBooks[2]);  break;
            case 4: currentBooksInTheTable[quantityOfBooksInTheTable] = buttonBooks[3]; setInfoKeeperRemoveBook(buttonBooks[3]);  break;
            case 5: currentBooksInTheTable[quantityOfBooksInTheTable] = buttonBooks[4]; setInfoKeeperRemoveBook(buttonBooks[4]);  break;
            case 6: currentBooksInTheTable[quantityOfBooksInTheTable] = buttonBooks[5]; setInfoKeeperRemoveBook(buttonBooks[5]);  break;
            case 7: setInfoKeeperAddBook(currentBooksInTheTable[0]); currentBooksInTheTable[0] = ""; break;
            case 8: setInfoKeeperAddBook(currentBooksInTheTable[1]); currentBooksInTheTable[1] = ""; break;
            case 9: setInfoKeeperAddBook(currentBooksInTheTable[2]); currentBooksInTheTable[2] = ""; break;
        }
        resetButtons();
    }
    void setInfoKeeperRemoveBook(string stg)
    {
        if(qualEscrivania == 1)
        {
            switch(stg)
            {
                case "A": infoKeeper.hasBookA = false; infoKeeper.placedBookA_1 = true; break;
                case "B": infoKeeper.hasBookB = false; infoKeeper.placedBookB_1 = true; break;
                case "C": infoKeeper.hasBookC = false; infoKeeper.placedBookC_1 = true; break;
                case "X": infoKeeper.hasBookX = false; infoKeeper.placedBookX_1 = true; break;
                case "Y": infoKeeper.hasBookY = false; infoKeeper.placedBookY_1 = true; break;
                case "Z": infoKeeper.hasBookZ = false; infoKeeper.placedBookZ_1 = true; break;
            }
        }
        if(qualEscrivania == 2)
        {
            switch(stg)
            {
                case "A": infoKeeper.hasBookA = false; infoKeeper.placedBookA_2 = true; break;
                case "B": infoKeeper.hasBookB = false; infoKeeper.placedBookB_2 = true; break;
                case "C": infoKeeper.hasBookC = false; infoKeeper.placedBookC_2 = true; break;
                case "X": infoKeeper.hasBookX = false; infoKeeper.placedBookX_2 = true; break;
                case "Y": infoKeeper.hasBookY = false; infoKeeper.placedBookY_2 = true; break;
                case "Z": infoKeeper.hasBookZ = false; infoKeeper.placedBookZ_2 = true; break;
            }
        }
    }
    void setInfoKeeperAddBook(string stg)
    {
        if(qualEscrivania == 1)
        {
            switch(stg)
            {
                case "A": infoKeeper.hasBookA = true; infoKeeper.placedBookA_1 = false; break;
                case "B": infoKeeper.hasBookB = true; infoKeeper.placedBookB_1 = false; break;
                case "C": infoKeeper.hasBookC = true; infoKeeper.placedBookC_1 = false; break;
                case "X": infoKeeper.hasBookX = true; infoKeeper.placedBookX_1 = false; break;
                case "Y": infoKeeper.hasBookY = true; infoKeeper.placedBookY_1 = false; break;
                case "Z": infoKeeper.hasBookZ = true; infoKeeper.placedBookZ_1 = false; break;
            }
        }
        if(qualEscrivania == 2)
        {
            switch(stg)
            {
                case "A": infoKeeper.hasBookA = true; infoKeeper.placedBookA_2 = false; break;
                case "B": infoKeeper.hasBookB = true; infoKeeper.placedBookB_2 = false; break;
                case "C": infoKeeper.hasBookC = true; infoKeeper.placedBookC_2 = false; break;
                case "X": infoKeeper.hasBookX = true; infoKeeper.placedBookX_2 = false; break;
                case "Y": infoKeeper.hasBookY = true; infoKeeper.placedBookY_2 = false; break;
                case "Z": infoKeeper.hasBookZ = true; infoKeeper.placedBookZ_2 = false; break;
            }
        }
    }
}
