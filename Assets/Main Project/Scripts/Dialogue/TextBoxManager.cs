using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;

public class TextBoxManager : MonoBehaviour
{
    //guarda linhas de texto para ser mostrado no dialogue box. Chama elas sequencialmente até acabar.
    //Se o dialogue box tiver desligado, o liga. Se os dialogos acabarem, desliga o dialogue box
    //A contagem começa no 0
    //geralmente, esse script sera chamado pelo CallAction no GameMaster
    [HideInInspector] public GameObject textBox;
    [HideInInspector] public TextMeshProUGUI text;
    public GameObject textBox0;
    public TextMeshProUGUI text0;
    public GameObject textBox1;
    public TextMeshProUGUI text1;
    public GameObject textBox2;
    public TextMeshProUGUI text2;
    private InfoKeeper infoKeeper;
    public string[] followUpText;
    public int[] followUpBox;
    public int currentTextNumber = -1;
    [HideInInspector]public int whenIsEventCalled = -1; //definide quando o evento sera chamado
    public UnityEvent pendingEvent; //Defino o evento que sera chamado
    private CallAction callAction;
    private int x;
    private bool isActive;
    public GameObject playerDetectArea;
    void Start()
    {
        textBox = textBox0;
        text = text0;

        infoKeeper = gameObject.GetComponent<InfoKeeper>();
        callAction = gameObject.GetComponent<CallAction>();
        foreach(string y in followUpText)
        {
            if(followUpText[x] == null)
            {
                followUpText[x] = "";
            }
            x++;
        }
    }
    public void callnextText()
    {
        currentTextNumber++;

        if(followUpBox[currentTextNumber] > 0)
        {
            if(followUpBox[currentTextNumber] != followUpBox[currentTextNumber - 1])
            {
                tradeWhichDialogue(followUpBox[currentTextNumber]);
            }
        }

        if(whenIsEventCalled == currentTextNumber)
        {
            whenIsEventCalled = -1;
            pendingEvent.Invoke();
        }
        if(followUpText[currentTextNumber] == "")
        {
            textBox.SetActive(false);
            Time.timeScale = 1;
            isActive = false;
            infoKeeper.gameIsBlockingInteraction = false;
        }
        else
        {
            text.text = followUpText[currentTextNumber];
            followUpText[currentTextNumber] = "";
        }
        
    }
    public void turnOnDialogueBox()
    {
        setWhichDialogue(followUpBox[0]);
        textBox.SetActive(true);
        Time.timeScale = 0;
        isActive = true;
        infoKeeper.gameIsBlockingInteraction = true;
        currentTextNumber = -1;
        callnextText();
    }
    public void setWhichDialogue(int whc)
    {
        switch (whc)
        {
            case 0: textBox = textBox0; text = text0; break;
            case 1: textBox = textBox1; text = text1; break;
            case 2: textBox = textBox2; text = text2; break;

            default: Debug.Log("There is no dialogue box above 3"); break;
        }
    }
    public void tradeWhichDialogue(int whc)
    {
        textBox0.SetActive(false);
        textBox1.SetActive(false);
        textBox2.SetActive(false);

        setWhichDialogue(whc);

        switch(whc)
        {
            case 0: textBox0.SetActive(true); break;
            case 1: textBox1.SetActive(true); break;
            case 2: textBox2.SetActive(true); break;
        }
    }
}
