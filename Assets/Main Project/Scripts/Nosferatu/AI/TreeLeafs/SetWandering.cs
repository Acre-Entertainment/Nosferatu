using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetWandering : TreeLeaf
{
    public static void run(TreeStart ts)
    {
        ts.status = "WANDERING";
        ts.resetTimers();
    }
}
