using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MulherPura : MonoBehaviour
{
    InfoKeeper infoKeeper;
    public UnityEvent hasFinishedPuzzle;
    private void Start() {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }
    public void checkPuzzle()
    {
        if(infoKeeper.placedBookA_1 == true && infoKeeper.placedBookX_1 == true && infoKeeper.placedBookC_1 == true && infoKeeper.placedBookB_2 == true && infoKeeper.placedBookZ_2 == true && infoKeeper.placedBookY_2 == true)
        {
            hasFinishedPuzzle.Invoke();
        }
    }
}
