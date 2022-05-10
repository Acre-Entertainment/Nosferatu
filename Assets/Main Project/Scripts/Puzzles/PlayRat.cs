using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRat : MonoBehaviour
{
    private InfoKeeper infoKeeper;
    public GameObject rat;
    private void Start() {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }
    public void playRatAnim()
    {
        if(infoKeeper.tutorialHasPlayedRat == false)
        {
            rat.SetActive(true);
            infoKeeper.tutorialHasPlayedRat = true;
        }
    }
}
