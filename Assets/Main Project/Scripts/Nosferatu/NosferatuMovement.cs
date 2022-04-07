using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NosferatuMovement : MonoBehaviour
{
    public GameObject startingDestination;
    public GameObject currentTarget;
    public List<GameObject> possibleRandomWanderingSpots;
    public GameObject[] startingPossibleRandomWanderingSpots;
    NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        foreach(GameObject go in startingPossibleRandomWanderingSpots)
        {
            possibleRandomWanderingSpots.Add(go);
        }
        if(startingDestination != null)
        {
            currentTarget = startingDestination;
            navMeshAgent.SetDestination(currentTarget.transform.position);
        }
    }
    public void setNewTarget(GameObject target)
    {
        currentTarget = target;
        navMeshAgent.SetDestination(currentTarget.transform.position);
    }
    public void setRandomTarget()
    {
        int randy = Random.Range(1, possibleRandomWanderingSpots.Count + 1);
        currentTarget = possibleRandomWanderingSpots[randy];
        navMeshAgent.SetDestination(currentTarget.transform.position);
    }
}
