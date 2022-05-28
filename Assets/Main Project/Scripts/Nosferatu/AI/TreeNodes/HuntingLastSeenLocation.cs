using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntingLastSeenLocation : TreeNode
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/LastSeenLocation";
        if(ts.nosferatuMovement.currentTarget == ts.lastSeenPlayerLocation)
        {
            HuntingIsInLastSeenLocation.run(ts);
        }
        else
        {
            SetTargetToPlayerLastLocation.run(ts);
        }
    }
}
