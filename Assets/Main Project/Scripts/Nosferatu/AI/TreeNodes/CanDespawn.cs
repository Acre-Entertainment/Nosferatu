using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanDespawn : MonoBehaviour
{
    public static void run(TreeStart ts)
    {
        if(ts.timeUntilDespawn <= 0 && ts.isGoingToDespawn == true)
        {
            Despawn.run(ts);
        }
        else
        {
            TreeWait.run(ts);
        }
    }
}
