using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StillGoingSpawn : TreeNode
{
    public static void run(TreeStart ts)
    {
        if(ts.isGoingToSpawn == true)
        {
            StillCanSpawn.run(ts);
        }
        else
        {
            TreeWait.run(ts);
        }
    }
}
