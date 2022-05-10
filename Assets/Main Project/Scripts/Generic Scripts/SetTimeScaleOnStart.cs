using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTimeScaleOnStart : MonoBehaviour
{
    public float timeScale;
    private void Start() {
        Time.timeScale = timeScale;
    }
}
