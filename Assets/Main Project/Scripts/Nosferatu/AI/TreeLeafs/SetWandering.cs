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
        ts.nosferatuMovement.setNewTarget(ts.player);
        ts.resetTimers();
    }
}
