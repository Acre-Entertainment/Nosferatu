using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStill : TreeLeaf
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/SetStill";
        Debug.Log(ts.lastAiPath);
        
        ts.status = "STILL";
        ts.resetTimers();
    }
}
