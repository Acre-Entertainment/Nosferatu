using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreeWanderingPlayerSight : TreeNode
{
    public static void run(TreeStart ts)
    {
        if(ts.sightZone.nosferatuHasLineOfSight == true)
        {
            SetHunting.run(ts);
        }
        else
        {
            WanderingSwitchTargets.run(ts);
        }
    }
}
