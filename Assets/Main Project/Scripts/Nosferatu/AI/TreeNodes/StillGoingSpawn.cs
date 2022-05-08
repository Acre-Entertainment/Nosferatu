using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StillGoingSpawn : TreeNode
{
    TreeWait treeWait;
    StillCanSpawn stillCanSpawn;
    public override IEnumerator run()
    {
        if(nosferatuStatus.isGoingToSpawn == true)
        {
            yield return stillCanSpawn.run();
        }
        else
        {
            yield return treeWait.run();
        }
    }
}
