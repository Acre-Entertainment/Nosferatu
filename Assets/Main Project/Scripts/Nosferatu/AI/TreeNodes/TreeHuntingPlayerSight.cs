using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreeHuntingPlayerSight : TreeNode
{
    public static void run(TreeStart ts)
    {
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
