using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenryFix : MonoBehaviour
{
    Vector3 position = new Vector3(0, -1, 0);
    Vector3 rotation = new Vector3(0, -80, 0);
    private void Update() {
        gameObject.transform.localPosition = position;
        gameObject.transform.localEulerAngles = rotation;
    }
}
