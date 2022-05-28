using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTargetToPlayerLastLocation : TreeLeaf
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/SetTargetToPlayerLastLocation";
        Debug.Log(ts.lastAiPath);
        
        ts.nosferatuMovement.setNewTarget(ts.lastSeenPlayerLocation);
        ts.nosferatuIsInLastSeenPlayerLocation = false;
    }
}
