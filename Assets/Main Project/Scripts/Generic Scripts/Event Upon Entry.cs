using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventUponEntry : MonoBehaviour
{
    //quando um gameObject com a tag entra na area, chama o evento. A area deve ter IsTrigger ativado e o objeto precisa de rigidbody.
    public UnityEvent eventToHappen;
    public string objectTag;
    void OnTriggerEnter(Collider taggedObject)
    {
        if(taggedObject.tag == objectTag)
        {
            eventToHappen.Invoke();
        }
    }
}
