using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM_Chest : MonoBehaviour
{
    InfoKeeper infoKeeper;
    public int keyNumber;

    private void Start()
    {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }

    public void activateThis()
    {
        switch(keyNumber)
        {
            case 1: infoKeeper.hasDormeKey1 = true; break;
            case 2: infoKeeper.hasDormeKey2 = true; break;
            case 3: infoKeeper.hasDormeKey3 = true; break;
            case 4: infoKeeper.hasDormeKey4 = true; break;
            case 5: infoKeeper.hasDormeKey5 = true; break;
        }
    }
}
