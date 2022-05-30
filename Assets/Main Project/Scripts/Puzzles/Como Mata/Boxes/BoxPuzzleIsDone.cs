using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoxPuzzleIsDone : MonoBehaviour
{
    public BoxPlace boxPlace1, boxPlace2, boxPlace3;
    public UnityEvent onPuzzleDone;
    InfoKeeper infoKeeper;

    private void Start() {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }

    public void checkPuzzle()
    {
        if(infoKeeper.metalBoxIn1 == true && infoKeeper.woodBoxIn2 && infoKeeper.clayBoxIn3 == true)
        {
            onPuzzleDone.Invoke();
        }
    }
}
