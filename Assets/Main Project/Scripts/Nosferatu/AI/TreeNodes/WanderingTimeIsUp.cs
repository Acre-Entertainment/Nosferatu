using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingTimeIsUp : TreeNode
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/TimeIsUp";
        if(ts.timeUntilSwitchFromWanderingToNot <= 0)
        {
            Despawn.run(ts);
        }
        else
        {
            SetNewWanderingLocation.run(ts);
        }
    }
}