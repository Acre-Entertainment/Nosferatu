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
    public GameObject textBox;
    public TextMeshProUGUI text;
    private InfoKeeper infoKeeper;
    public string[] followUpText;
    public int currentTextNumber = -1;
    [HideInInspector]public int whenIsEventCalled = -1; //definide quando o evento sera chamado
    public UnityEvent pendingEvent; //Defino o evento que sera chamado
    private CallAction callAction;
    private int x;
    private bool isActive;
    public GameObject playerDetectArea;
    void Start()
    {
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
        textBox.SetActive(true);
        Time.timeScale = 0;
        isActive = true;
        infoKeeper.gameIsBlockingInteraction = true;
        currentTextNumber = -1;
        callnextText();
    }
}