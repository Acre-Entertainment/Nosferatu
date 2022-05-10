using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public SightZone sightZone;
    public GameObject player;
    public GameObject hidingText;
    public GameObject noHidingText;
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
        }
    }
}
