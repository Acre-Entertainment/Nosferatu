using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntingIsInLastSeenLocation : TreeNode
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/IsInLastSeenLocation";
        if(ts.nosferatuIsInLastSeenPlayerLocation == true)
        {
            SetWandering.run(ts);
        }
        else
        {
            TreeWait.run(ts);
        }
    }
}
