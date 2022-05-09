using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeStart : MonoBehaviour
{
    public NearZone nearZone;
    public SightZone sightZone;
    public NosferatuMovement nosferatuMovement;
    public string status = "NOT";
    //o Nosferatu pode estar HUNTING WANDERING STILL NOT
    public bool isGoingToSpawn;
    public float timeUntilSpawn;
    public bool isGoingToDespawn;
    public float timeUntilDespawn;
    public float timeBetweenSwitchingWanderingTargets;
    public float timeUntillNextWanderingSwitch;
    public float timeWandering;
    public float timeToSwitchFromWanderingToStill;
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
        if(status == "WANDERING")
        {
            timeUntillNextWanderingSwitch = timeUntillNextWanderingSwitch - 1 * Time.deltaTime;
            timeToSwitchFromWanderingToStill = timeToSwitchFromWanderingToStill - 1 * Time.deltaTime;
        }

        TreeCheckStatus.run(this);
    }
}
