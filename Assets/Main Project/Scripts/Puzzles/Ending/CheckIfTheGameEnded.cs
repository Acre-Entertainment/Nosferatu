using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckIfTheGameEnded : MonoBehaviour
{
    InfoKeeper infoKeeper;
    private void Start() {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>(); 
    }
    public void activateThis()
    {
        if(infoKeeper.puzzleMulherPuraIsOver == true && infoKeeper.puzzleComoMataOver && infoKeeper.puzzleOndeDormeIsOver && infoKeeper.puzzleRatosAmigosIsOver && infoKeeper.puzzleOQueComeIsOver == true)
        {

        }
    }
}
