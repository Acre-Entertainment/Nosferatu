using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeBase : MonoBehaviour
{
    public NosferatuStatus nosferatuStatus;
    void Start()
    {
        nosferatuStatus = GameObject.FindGameObjectWithTag("NosferatuAI").GetComponent<NosferatuStatus>();
    }
    public virtual IEnumerator run()
    {
        yield return new WaitForEndOfFrame();
    }
    public string value;
    public string returnTrue()
    {
        return value;
    }
}
