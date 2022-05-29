using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : TreeLeaf
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/Spawn";
        Debug.Log(ts.lastAiPath);
        
        int randy = Random.Range(0, ts.spawnLocations.Count + 1);
        GameObject randomSpawn = ts.spawnLocations[randy];
        ts.Nosferatu.SetActive(true);
        ts.Nosferatu.transform.position = randomSpawn.transform.position;
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
