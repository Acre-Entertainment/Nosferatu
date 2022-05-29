using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NosferatuMovement : MonoBehaviour
{
    public GameObject startingDestination;
    public GameObject currentTarget;
    public bool stayStill;
    public List<GameObject> possibleRandomWanderingSpots;
    NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        if(startingDestination != null)
        {
            currentTarget = startingDestination;
            navMeshAgent.SetDestination(currentTarget.transform.position);
        }
    }
    void Update()
    {
        if(stayStill == true && currentTarget != gameObject)
        {
            currentTarget = gameObject;
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
    public void setSpeed(float LeSpeed)
    {
        navMeshAgent.speed = LeSpeed;
    }
}
