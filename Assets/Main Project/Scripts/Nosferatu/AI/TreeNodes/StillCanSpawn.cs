using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StillCanSpawn : TreeNode
{
    public static void run(TreeStart ts)
    {
        if(ts.timeUntilSpawn <= 0)
        {
            Spawn.run(ts);
        }
        else
        {
            TreeWait.run(ts);
        }
    }
}
