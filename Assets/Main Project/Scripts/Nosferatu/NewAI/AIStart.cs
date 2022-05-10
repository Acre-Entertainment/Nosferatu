using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStart : AINode
{
    public AINode son;
    void Update()
    {
        son.run();
    }
}
