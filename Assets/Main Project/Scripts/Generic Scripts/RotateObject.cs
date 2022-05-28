using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float x, y, z;

    public void rotateThis()
    {
        gameObject.transform.transform.localEulerAngles += new Vector3(x, y, z);
    }
}
