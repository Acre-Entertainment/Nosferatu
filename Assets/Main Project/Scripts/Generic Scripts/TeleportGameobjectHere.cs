using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportGameobjectHere : MonoBehaviour
{
    public GameObject gameObjectToTeleport;
    public void teleport()
    {
        gameObjectToTeleport.transform.position = gameObject.transform.position;
    }
}
