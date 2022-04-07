using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NosferatuAI : MonoBehaviour
{
    private InfoKeeper infoKeeper;
    private NosferatuMovement nosferatuMovement;
    GameObject nosferatu;
    public UnityEvent onNosferatuSpawn;
    public UnityEvent onNosferatuDespawn;
    public float timeToSpawnLowerEnd;
    public float timeToSpawnUpperEnd;
    public float nosferatuDelay;
    public bool hasSpawned;
    public int wanderingsDone;
    public int wandersBeforeDespawn;
    public string status = "wander";
    void Start()
    {
        nosferatu = GameObject.FindGameObjectWithTag("Nosferatu");
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
        nosferatuMovement = nosferatu.GetComponent<NosferatuMovement>();
        StartCoroutine(Node_Start());
    }
    IEnumerator Node_Start() //a arvore da ai sempre vai ficar repetindo
    {
        while(true)
        {
        yield return StartCoroutine(Node_Spawning());
        }
    }
    IEnumerator Node_Spawning() //ve se o Nosferato ja spawnou. Se não, espera um tempo, se sim, continua pela arvore.
    {
        if(hasSpawned == false)
        {
            yield return StartCoroutine(Branch_waitForSpawn());
        }
        else
        {
            yield return StartCoroutine(Node_Status());
        }
    }
    IEnumerator Branch_waitForSpawn() //espera o spawn
    {
        yield return new WaitForSeconds(Random.Range(timeToSpawnLowerEnd, timeToSpawnUpperEnd));
        onNosferatuSpawn.Invoke();
        hasSpawned = true;
    }
    IEnumerator Node_Status() //verifica o status do Nosferatu
    {
        switch(status)
        {
            case "wander":
                yield return StartCoroutine(Node_Wander_seePlayer());
                break;
            case "wait":

                break;
            case "hunt":

                break;
        }
    }
    IEnumerator Node_Wander_seePlayer() // verifica se o Nosferatu andando ve o jogador
    {
        if(infoKeeper.nosferatuRoom == infoKeeper.playerRoom)
        {
            yield return StartCoroutine(Branch_Wander_setStatusAsHunt());
        }
        else
        {
            yield return StartCoroutine(Node_Wander_hasWanderTarget());
        }
    }
    IEnumerator Branch_Wander_setStatusAsHunt() //coloqua o Nosferato para caçar o jogador se ele ver o jogador enquanto estiver procurando
    {
        yield return new WaitForSeconds(nosferatuDelay);
        status = "hunt";
    }
    IEnumerator Node_Wander_hasWanderTarget() //verifica se o Nosferatu tem um lugar que ele quer ir
    {
        if(nosferatuMovement == null)
        {
            yield return StartCoroutine(Branch_Wander_setTarget());
        }
        else
        {

        }
    }
    IEnumerator Node_Wander_hasWanderedEnough()
    {
        yield return 0;
    }
    IEnumerator Branch_Wander_setTarget()
    {
        nosferatuMovement.setRandomTarget();
        yield return new WaitForSeconds(nosferatuDelay);
    }
}
