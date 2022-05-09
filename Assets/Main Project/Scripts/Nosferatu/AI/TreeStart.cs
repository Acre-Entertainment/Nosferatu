using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeStart : MonoBehaviour
{
    public NearZone nearZone;
    public SightZone sightZone;
    public string status = "NOT";
    //o Nosferatu pode estar HUNTING WANDERING STILL NOT
    public bool isGoingToSpawn;
    public float timeUntilSpawn;
    public bool isGoingToDespawn;
    public float timeUntilDespawn;
    void Update()
    {
        if(isGoingToSpawn == true)
        {
            timeUntilSpawn = timeUntilSpawn - 1 * Time.deltaTime;
        }
        if(isGoingToDespawn == true)
        {
            timeUntilDespawn = timeUntilDespawn - 1 * Time.deltaTime;
        }

        TreeCheckStatus.run(this);
    }
}
