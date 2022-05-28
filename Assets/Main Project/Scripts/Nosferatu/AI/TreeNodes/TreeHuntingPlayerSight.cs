using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreeHuntingPlayerSight : TreeNode
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/PlayerSight";
        if(ts.sightZone.nosferatuHasLineOfSight == true)
        {
            HuntingPlayerTarget.run(ts);
        }
        else
        {
            HuntingLastSeenLocation.run(ts);
        }
    }
}
