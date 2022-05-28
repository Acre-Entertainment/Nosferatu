using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNewWanderingLocation : TreeLeaf
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/SetNewWanderingLocation";
        Debug.Log(ts.lastAiPath);
        
        ts.nosferatuMovement.setRandomTarget();
        ts.timeUntillNextWanderingSwitch = ts.timeBetweenSwitchingWanderingTargets;
    }
}
