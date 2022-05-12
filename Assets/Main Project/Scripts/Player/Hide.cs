using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public SightZone sightZone;
    public GameObject player;
    public GameObject hidingText;
    public GameObject noHidingText;
    private InfoKeeper infoKeeper;
    private void Start() {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }
    public void CheckAndHide()
    {
        if(sightZone.nosferatuHasLineOfSight == true)
        {
            noHidingText.SetActive(true);
        }
        else
        {
            noHidingText.SetActive(false);
            hidingText.SetActive(true);
            player.SetActive(false);
            infoKeeper.playerIsHiding = true;
        }
    }
    public void Unhide()
    {
        noHidingText.SetActive(false);
        hidingText.SetActive(false);
        player.SetActive(true);
        infoKeeper.playerIsHiding = false;
    }
}
