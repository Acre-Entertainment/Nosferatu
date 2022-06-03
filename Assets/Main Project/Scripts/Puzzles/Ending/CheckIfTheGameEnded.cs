using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckIfTheGameEnded : MonoBehaviour
{
    InfoKeeper infoKeeper;
    bool hasAlreadyEnded;
    public UnityEvent onLastPuzzleFinish;

    private void Start()
    {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>(); 
    }

    public void activateThis()
    {
        if(infoKeeper.puzzleMulherPuraIsOver == true && infoKeeper.puzzleComoMataOver == true && infoKeeper.puzzleOndeDormeIsOver == true && infoKeeper.puzzleRatosAmigosIsOver == true && infoKeeper.puzzleOQueComeIsOver == true && hasAlreadyEnded == false)
        {
            onLastPuzzleFinish.Invoke();
        }
    }
}
