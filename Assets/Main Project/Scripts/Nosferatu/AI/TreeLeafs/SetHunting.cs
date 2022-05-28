using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHunting : TreeLeaf
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/SetHunting";
        Debug.Log(ts.lastAiPath);
        
        ts.status = "HUNTING";
    }
}
