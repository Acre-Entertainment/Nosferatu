using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreeStillPlayerNear : TreeNode
{
    public static void run(TreeStart ts)
    {
        if(ts.nearZone.playerIsInside == true)
        {
            SetHunting.run(ts);
        }
        else
        {
            CanDespawn.run(ts);
        }
    }
}
