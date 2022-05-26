using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CM_checkThreeKeyHole : MonoBehaviour
{
    InfoKeeper InfoKeeper;
    public UnityEvent onPuzzleSolved;

    private void Start() {
        InfoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }

    public void checkPuzzle()
    {
        if(InfoKeeper.hasDormeKey2 == true && InfoKeeper.hasDormeKey3 == true && InfoKeeper.hasDormeKey4 == true)
        {
            onPuzzleSolved.Invoke();
        }
    }
}
