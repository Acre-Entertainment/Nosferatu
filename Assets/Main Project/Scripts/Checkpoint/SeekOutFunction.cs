using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekOutFunction : MonoBehaviour
{
    public void LoadThis()
    {
        GameObject.FindGameObjectWithTag("Checkpoint").GetComponent<Checkpoint>().seekOutScene();
    }
}
