using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : TreeLeaf
{
    public static void run(TreeStart ts)
    {
        ts.lastAiPath = ts.lastAiPath + "/Despawn";
        Debug.Log(ts.lastAiPath);
        
        ts.Nosferatu.SetActive(false);
        ts.resetTimers();
        ts.status = "NOT";
    }
}
