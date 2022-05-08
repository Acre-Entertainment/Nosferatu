using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DeathZone : MonoBehaviour
{
    UnityEvent onPlayerDeath;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            onPlayerDeath.Invoke();
        }
    }
}
