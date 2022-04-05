using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour
{
    //guarda linhas de texto para ser mostrado no dialogue box. Chama elas sequencialmente até acabar.
    //Se o dialogue box tiver desligado, o liga. Se os dialogos acabarem, desliga o dialogue box
    public GameObject textBox;
    public GameObject textObject;
    private Text text;
    public string[] followUpText = new string[50];
    public int currentTextNumber;
    void Start()
    {
        text = textObject.GetComponent<Text>();
    }
    public void callnextText()
    {
        //se não tiver dialogo, encerra
        if(followUpText[currentTextNumber] == "")
        {
            textBox.SetActive(false);
            currentTextNumber = 0;
        }
        //se tiver, chama o proxiomo dialogo.
        else
        {
            text.text = followUpText[currentTextNumber]; //coloka o texto
            followUpText[currentTextNumber] = ""; //reseta o espaço
            currentTextNumber++; //vai pra proxima linha
            if(textBox.activeInHierarchy == false)
            {
                textBox.SetActive(true);
            }
        }
        
    }
}
