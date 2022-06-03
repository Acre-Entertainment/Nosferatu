using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spawn : TreeLeaf
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/Spawn";
        Debug.Log(ts.lastAiPath);

        ts.nosferatuEvents.InvokeOnSpawn();      
        int randy = Random.Range(0, ts.spawnLocations.Count);
        GameObject randomSpawn = ts.spawnLocations[randy];
        ts.Nosferatu.SetActive(true);
        ts.Nosferatu.GetComponent<NavMeshAgent>().Warp(randomSpawn.transform.position);
        Debug.Log("Nosferatu Spawned in: " + randomSpawn.transform.position.x + "/" + randomSpawn.transform.position.y + "/" + randomSpawn.transform.position.z);
        ts.status = "WANDERING";
        if(ts.player.activeSelf == true)
        {
            ts.nosferatuMovement.setNewTarget(ts.player);
        }
        else
        {
            ts.nosferatuMovement.setRandomTarget();
        }
        ts.resetTimers();
    }
}
