using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTargetToPlayer : TreeLeaf
{
    public static void run(TreeStart ts)
    {
        ts.nosferatuMovement.setNewTarget(ts.player);
    }
}
