using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NosferatuMovement : MonoBehaviour
{
    public GameObject startingDestination;
    NavMeshAgent navMeshAgent;
    void Start()
    {
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
        if(startingDestination != null)
        {
            navMeshAgent.SetDestination(startingDestination.transform.position);
        }
    }
    void setNewTarget(GameObject target)
    {
        navMeshAgent.SetDestination(target.transform.position);
    }
}
