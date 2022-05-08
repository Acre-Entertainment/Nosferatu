using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeStart : TreeBase
{
    TreeCheckStatus treeCheckStatus;
    void Update()
    {
        StartCoroutine(treeCheckStatus.run());
    }
}
