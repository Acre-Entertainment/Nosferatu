using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CM_checkThreeKeyHole : MonoBehaviour
{
    InfoKeeper infoKeeper;
    public UnityEvent onPuzzleSolved;

    private void Start() {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }

    public void checkPuzzle()
    {
        if(infoKeeper.hasDormeKey3 == true && infoKeeper.hasDormeKey4 == true && infoKeeper.hasDormeKey5 == true)
        {
            onPuzzleSolved.Invoke();
        }
    }
}
