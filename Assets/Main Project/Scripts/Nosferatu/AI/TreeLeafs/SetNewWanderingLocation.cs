using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNewWanderingLocation : TreeLeaf
{
    public static void run(TreeStart ts)
    {
        ts.nosferatuMovement.setRandomTarget();
        ts.timeUntillNextWanderingSwitch = ts.timeBetweenSwitchingWanderingTargets;
    }
}
