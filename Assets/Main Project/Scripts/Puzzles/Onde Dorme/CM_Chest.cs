using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CM_Chest : MonoBehaviour
{
    InfoKeeper InfoKeeper;
    public int keyNumber;

    private void Start()
    {
        InfoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }

    public void activateThis()
    {
        switch(keyNumber)
        {
            case 1: InfoKeeper.hasDormeKey1 = true; break;
            case 2: InfoKeeper.hasDormeKey2 = true; break;
            case 3: InfoKeeper.hasDormeKey3 = true; break;
            case 4: InfoKeeper.hasDormeKey4 = true; break;
            case 5: InfoKeeper.hasDormeKey5 = true; break;
        }
    }
}
