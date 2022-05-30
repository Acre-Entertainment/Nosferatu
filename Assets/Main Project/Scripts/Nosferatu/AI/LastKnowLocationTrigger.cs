using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastKnowLocationTrigger : MonoBehaviour
{
    public string collisionTag;
    public TreeStart treeStart;
    void OnTriggerEnter(Collider other) {
        if(other.tag == "Nosferatu")
        {
            treeStart.nosferatuIsInLastSeenPlayerLocation = true;
            
        }
    }
}
