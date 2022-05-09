using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingSwitchTargets : TreeNode
{
    public static void run(TreeStart ts)
    {
        if(ts.timeBetweenSwitchingWanderingTargets <= 0)
        {

        }
        else
        {
            TreeWait.run(ts);
        }
    }
}
