using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeStart : MonoBehaviour
{
    public string lastAiPath;
    public GameObject Nosferatu;
    public GameObject player;
    public GameObject lastSeenPlayerLocation;
    public bool nosferatuIsInLastSeenPlayerLocation;
    public NearZone nearZone;
    public SightZone sightZone;
    public NosferatuMovement nosferatuMovement;
    public string status = "NOT";
    //o Nosferatu pode estar HUNTING WANDERING STILL NOT
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
    public float timeToStopHunting;
    public InfoKeeper infoKeeper;
    private void Start() {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }
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

        lastAiPath = "Tree Start";
        TreeCheckStatus.run(this);
    }
    public void resetTimers()
    {
        timeUntilSpawn = timeToSpawn;
        timeUntilDespawn = timeToDespawn;
        timeUntillNextWanderingSwitch = timeBetweenSwitchingWanderingTargets;
        timeUntilSwitchFromWanderingToStill = timeToSwitchFromWanderingToStill;
    }
}
