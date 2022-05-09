using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStill : TreeLeaf
{
    public static void run(TreeStart ts)
    {
        ts.status = "STILL";
    }
}
