using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class TreeWait : TreeLeaf
{
    public override IEnumerator run()
    {
        yield return new WaitForSeconds(5);
    }
}
