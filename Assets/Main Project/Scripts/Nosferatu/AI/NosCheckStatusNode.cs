using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NosCheckStatusNode : MonoBehaviour
{
    public IEnumerator CheckStatus()
    {
        yield return new WaitForEndOfFrame();
    }
}
