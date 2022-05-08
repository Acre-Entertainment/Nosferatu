using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCheckStatus : TreeNode
{
    public static void run(TreeStart ts)
    {
        switch(ts.status)
        {
            case "HUNTING":
                //TreeHuntingPlayerSight.run(ts);
                break;
            case "WANDERING":
                //TreeWanderingPlayerSight.run(ts);
                break;
            case "STILL":
                //TreeStillPlayerNear.run(ts);
                break;
            case "NOT":
                StillGoingSpawn.run(ts);
                break;
            default:
                StillGoingSpawn.run(ts);
                break;
        }
    }
}
