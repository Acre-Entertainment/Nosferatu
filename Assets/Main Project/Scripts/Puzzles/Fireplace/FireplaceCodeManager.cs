using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireplaceCodeManager : MonoBehaviour
{
    //Script para o codigo da lareira
    public int code1, code2, code3, code4;
    public int correctCode1, correctCode2, correctCode3, correctCode4;
    public GameObject number1Object, number2Object, number3Object, number4Object;
    private Text text1, text2, text3, text4;
    private InfoKeeper infoKeeper;
    private CallAction callAction;
    private void Start()
    {
        text1 = number1Object.GetComponent<Text>();
        text2 = number2Object.GetComponent<Text>();
        text3 = number3Object.GetComponent<Text>();
        text4 = number4Object.GetComponent<Text>();
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
        callAction = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<CallAction>();
    }
    //bugfix
    private void OnEnable()
    {
        blockInteraction();
    }
    private IEnumerator blockInteraction()
    {
        yield return 0;
        infoKeeper.gameIsBlockingInteraction = true;
    }
    //bug fix

    //funçoes para mexer na lareira
    public void addOne()
    {
        code1++;
        if(code1 == 10)
        {
            code1 = 0;
        }
        updateText();
    }
    public void addTwo()
    {
        code2++;
        if(code2 == 10)
        {
            code2 = 0;
        }
        updateText();
    }
    public void addThree()
    {
        code3++;
        if(code3 == 10)
        {
            code3 = 0;
        }
        updateText();
    }
    public void addFour()
    {
        code4++;
        if(code4 == 10)
        {
            code4 = 0;
        }
        updateText();
    }
    public void removeOne()
    {
        code1--;
        if(code1 == -1)
        {
            code1 = 9;
        }
        updateText();
    }
    public void removeTwo()
    {
        code2--;
        if(code2 == -1)
        {
            code2 = 9;
        }
        updateText();
    }
    public void removeThree()
    {
        code3--;
        if(code3 == -1)
        {
            code3 = 9;
        }
        updateText();
    }
    public void removeFour()
    {
        code4--;
        if(code4 == -1)
        {
            code4 = 9;
        }
        updateText();
    }
    public void updateText()
    {
        text1.text = "" + code1;
        text2.text = "" + code2;
        text3.text = "" + code3;
        text4.text = "" + code4;
    }
    public void EnterCode()
    {
        if(code1 == correctCode1 && code2 == correctCode2 && code3 == correctCode3 && code4 == correctCode4)
        {
            callAction.Puzzle_Fireplace_Success();
        }
        else
        {
            callAction.Puzzle_Fireplace_Failure();
        }
    }
}
