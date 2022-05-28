using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanDespawn : TreeNode
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/CanDespawn";
        if(ts.timeUntilDespawn <= 0 && ts.isGoingToDespawn == true)
        {
            Despawn.run(ts);
        }
        else
        {
            TreeWait.run(ts);
        }
    }
}
