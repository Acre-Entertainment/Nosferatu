using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingTimeIsUp : TreeNode
{
    public static void run(TreeStart ts)
    {
        if(ts.timeToSwitchFromWanderingToStill <= 0)
        {
            SetStill.run(ts);
        }
        else
        {
            SetNewWanderingLocation.run(ts);
        }
    }
}