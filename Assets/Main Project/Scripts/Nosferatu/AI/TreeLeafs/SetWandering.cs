using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWandering : TreeLeaf
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/SetWandering";
        Debug.Log(ts.lastAiPath);
        
        ts.nosferatuEvents.InvokeOnLosingPlayer();    
        ts.status = "WANDERING";
        if(ts.player.activeSelf == true)
        {
            ts.lastSeenPlayerLocation.transform.position = ts.player.transform.position;
            ts.nosferatuMovement.setNewTarget(ts.lastSeenPlayerLocation);
        }
        else
        {
            ts.nosferatuMovement.setRandomTarget();
        }
        ts.resetTimers();
    }
}
