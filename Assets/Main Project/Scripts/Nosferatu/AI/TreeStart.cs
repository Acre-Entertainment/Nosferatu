using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeStart : MonoBehaviour
{
    public NosferatuEvents nosferatuEvents;
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
    [HideInInspector]public float timeToDespawn;
    [HideInInspector]public float timeUntilDespawn;
    public float timeBetweenSwitchingWanderingTargets;
    public float timeUntillNextWanderingSwitch;
    public float timeToSwitchFromWanderingToNot;
    public float timeUntilSwitchFromWanderingToNot;
    public bool lastHunt;
    //public float timeToStopHunting;
    public InfoKeeper infoKeeper;

    private void Start()
    {
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
            timeUntilSwitchFromWanderingToNot = timeUntilSwitchFromWanderingToNot - 1 * Time.deltaTime;
        }

        lastAiPath = "Tree Start";
        TreeCheckStatus.run(this);
    }
    public void resetTimers()
    {
        timeUntilSpawn = timeToSpawn;
        timeUntilDespawn = timeToDespawn;
        timeUntillNextWanderingSwitch = timeBetweenSwitchingWanderingTargets;
        timeUntilSwitchFromWanderingToNot = timeToSwitchFromWanderingToNot;
    }
    public void callLeaf(string stg)
    {
        switch(stg)
        {
            case "Despawn": Despawn.run(this); break;
            case "Spawn": Spawn.run(this); break;
        }
    }
    public void changeBool(string stg)
    {
        switch(stg)
        {
            case "isGoingToDespawn": isGoingToDespawn = !isGoingToDespawn; break;
        }
    }
    public void setStatus(string stg)
    {
        status = stg;
    }
    public void addSpanwWanderLocation(GameObject go)
    {
        bool duplicate = false;
        foreach (GameObject gosl in spawnLocations)
        {
            if(gosl == go)
            duplicate = true;
        }
        if(duplicate == false)
        {
            spawnLocations.Add(go);
        }

        duplicate = false;
        foreach (GameObject gows in nosferatuMovement.possibleRandomWanderingSpots)
        {
            if(gows == go)
            duplicate = true;
        }
        if(duplicate == false)
        {
            nosferatuMovement.possibleRandomWanderingSpots.Add(go);
        }
    }
    public void setUntilSpawnTime(float f)
    {
        timeUntilSpawn = f;
    }
}
