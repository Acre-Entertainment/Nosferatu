using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckMesaTable : MonoBehaviour
{
    InfoKeeper infoKeeper;
    public UnityEvent onActivation;
    public UnityEvent onNotActivation;
    public UnityEvent onPuzzleComplete;

    private void Start()
    {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }

    public void activateThis()
    {
        if((infoKeeper.ratoTablePosition1 == 3) && (infoKeeper.ratoTablePosition2 == 2 || infoKeeper.ratoTablePosition2 == 4) && (infoKeeper.ratoTablePosition3 == 4))
        {
            onActivation.Invoke();
        }
        else
        {
            onNotActivation.Invoke();
        }
    }
    public void completePuzzle()
    {
        onPuzzleComplete.Invoke();
    }
}
