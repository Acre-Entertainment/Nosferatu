using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWandering : TreeLeaf
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/SetWandering";
        Debug.Log(ts.lastAiPath);
        
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
