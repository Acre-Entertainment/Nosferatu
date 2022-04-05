using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class TextBoxManager : MonoBehaviour
{
    //guarda linhas de texto para ser mostrado no dialogue box. Chama elas sequencialmente até acabar.
    //Se o dialogue box tiver desligado, o liga. Se os dialogos acabarem, desliga o dialogue box
    //A contagem começa no 0
    //geralmente, esse script sera chamado pelo CallAction no GameMaster
    public GameObject textBox;
    public GameObject textObject;
    private Text text;
    private InfoKeeper infoKeeper;
    public string[] followUpText = new string[100];
    public int currentTextNumber;
    [HideInInspector]public int whenIsEventCalled = -1; //definide quando o evento sera chamado
    [HideInInspector]public UnityEvent pendingEvent; //Defino o evento que sera chamado
    private CallAction callAction;
    void Start()
    {
        text = textObject.GetComponent<Text>();
        infoKeeper= gameObject.GetComponent<InfoKeeper>();
        callAction.gameObject.GetComponent<CallAction>();
    }
    void Update()
    {
        //checa se o jogador apertou o enter e se a caixa de dialogo está aberta. Se sim, vai para a proxima linha de dialogo.
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            if(textBox.activeInHierarchy == true)
            {
                callnextText();
            }
        }
    }
    public void callnextText()
    {
        //se tiver no dialogue para chamar um UnityEvent, o chama e reseta o counter de chamar eventos
        if(whenIsEventCalled == currentTextNumber)
        {
            pendingEvent.Invoke();
            whenIsEventCalled = -1;
        }
        //se não tiver dialogo, encerra
        if(followUpText[currentTextNumber] == "")
        {
            textBox.SetActive(false);
            infoKeeper.gameIsBlockingInteraction = false; //faz com que o jogado n ative coisas durante o dialogue
            currentTextNumber = 0;
        }
        //se tiver, chama o proxiomo dialogo.
        else
        {
            text.text = followUpText[currentTextNumber]; //coloca o texto
            followUpText[currentTextNumber] = ""; //reseta o espaço
            currentTextNumber++; //vai pra proxima linha
            if(textBox.activeInHierarchy == false)
            {
                textBox.SetActive(true);
                infoKeeper.gameIsBlockingInteraction = true;
            }
        }
        
    }
}
