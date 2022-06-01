using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NosferatuEvents : MonoBehaviour
{
    public UnityEvent onSpawn;
    public UnityEvent onSetHunting;
    public UnityEvent onLosingPlayer;
    public UnityEvent onDespawn;

    public void InvokeOnSpawn()
    {
        onSpawn.Invoke();
    }
    public void InvokeOnSetHunting()
    {
        onSetHunting.Invoke();
    }
    public void InvokeOnLosingPlayer()
    {
        onLosingPlayer.Invoke();
    }
    public void InvokeOnDespawn()
    {
        onDespawn.Invoke();
    }
}
