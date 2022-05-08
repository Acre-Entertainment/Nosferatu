using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NosferatuStatus : MonoBehaviour
{
    public bool isActive;
    public bool isWandering;
    public bool isHunting;
    public float timeUntilDespawn;
    public float timeUntilSpawn;
    void Update()
    {
        timeUntilDespawn = timeUntilDespawn - 1 * Time.deltaTime;
        timeUntilSpawn = timeUntilSpawn - 1 * Time.deltaTime;
    }
}

