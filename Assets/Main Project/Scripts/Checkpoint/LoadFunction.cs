using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadFunction : MonoBehaviour
{
    public void LoadThis()
    {
        GameObject.FindGameObjectWithTag("Checkpoint").GetComponent<Checkpoint>().Load();
    }
}
