using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveFunction : MonoBehaviour
{
    public void SaveThis()
    {
        GameObject.FindGameObjectWithTag("Checkpoint").GetComponent<Checkpoint>().Save();
    }
}
