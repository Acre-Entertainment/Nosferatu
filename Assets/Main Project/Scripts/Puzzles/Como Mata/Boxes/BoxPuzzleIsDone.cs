using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BoxPuzzleIsDone : MonoBehaviour
{
    public BoxPlace boxPlace1, boxPlace2, boxPlace3;
    public UnityEvent onPuzzleDone;

    public void checkPuzzle()
    {
        if(boxPlace1.hasMetalBox == true && boxPlace2.hasWoodBox == true && boxPlace2.hasClayBox)
        {
            onPuzzleDone.Invoke();
        }
    }
}
