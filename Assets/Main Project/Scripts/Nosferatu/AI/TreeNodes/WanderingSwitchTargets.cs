using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingSwitchTargets : TreeNode
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/SwitchTarget";
        if(ts.timeUntillNextWanderingSwitch <= 0)
        {
            WanderingTimeIsUp.run(ts);
        }
        else
        {
            TreeWait.run(ts);
        }
    }
}
