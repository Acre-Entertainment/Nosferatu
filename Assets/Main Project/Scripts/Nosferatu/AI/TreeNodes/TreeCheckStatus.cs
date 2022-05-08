using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreeCheckStatus : TreeNode
{
    TreeHuntingPlayerSight treeHuntingPlayerSight;
    TreeWanderingPlayerSight treeWanderingPlayerSight;
    TreeStillPlayerNear treeStillPlayerNear;
    StillGoingSpawn stillGoingSpawn;
    public override IEnumerator run()
    {
        switch(nosferatuStatus.status)
        {
            case "HUNTING":
                yield return treeHuntingPlayerSight.run();
                break;
            case "WANDERING":
                yield return treeWanderingPlayerSight.run();
                break;
            case "STILL":
                yield return treeStillPlayerNear.run();
                break;
            case "NOT":
                yield return stillGoingSpawn.run();
                break;
            default:
                yield return stillGoingSpawn.run();
                break;
        }
    }
}
