using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NosferatuData : MonoBehaviour
{
    public GameObject Nosferatu;
    public NearZone nearZone;
    public SightZone sightZone;
    public NosferatuMovement nosferatuMovement;
    public string status = "NOT";
    public List<GameObject> spawnLocations = new List<GameObject>();
    public bool isGoingToSpawn;
    public float timeToSpawn;
    public float timeUntilSpawn;
    public bool isGoingToDespawn;
    public float timeToDespawn;
    public float timeUntilDespawn;
    public float timeBetweenSwitchingWanderingTargets;
    public float timeUntillNextWanderingSwitch;
    public float timeToSwitchFromWanderingToStill;
    public float timeUntilSwitchFromWanderingToStill;
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
    }
    public void resetTimers()
    {
        timeUntilSpawn = timeToSpawn;
        timeUntilDespawn = timeToDespawn;
        timeUntillNextWanderingSwitch = timeBetweenSwitchingWanderingTargets;
        timeUntilSwitchFromWanderingToStill = timeToSwitchFromWanderingToStill;
    }
}
