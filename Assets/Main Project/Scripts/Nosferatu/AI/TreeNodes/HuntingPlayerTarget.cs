using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuntingPlayerTarget : TreeNode
{
    public static void run(TreeStart ts)
    {
        if(ts.nosferatuMovement.currentTarget == ts.player)
        {
            TreeWait.run(ts);
        }
        else
        {
            SetTargetToPlayer.run(ts);
        }
    }
}
