using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPlace : MonoBehaviour
{
    public int whichBoxPlace;
    InfoKeeper infoKeeper;
    public bool hasMetalBox, hasWoodBox, hasClayBox;
    public GameObject boxPlaceUI;

    private void Start() {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }
    public void activateThis()
    {
        boxPlaceUI.GetComponent<BoxPlaceUI>().boxPlace = this;
        boxPlaceUI.SetActive(true);
        Time.timeScale = 0;
    }
}
