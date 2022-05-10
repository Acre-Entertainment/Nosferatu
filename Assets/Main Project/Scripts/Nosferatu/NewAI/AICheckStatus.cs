using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICheckStatus : AINode
{
    public AINode hunting;
    public AINode wandering;
    public AINode still;
    public AINode not;
    public override void run()
    {
        switch(nosferatuData.status)
        {
            case "HUNTING":
                hunting.run();
                break;
            case "WANDERING":
                wandering.run();
                break;
            case "STILL":
                still.run();
                break;
            case "NOT":
                not.run();
                break;
            default:
                not.run();
                break;
        }
    }
}
