using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpurrarObjetos : MonoBehaviour
{
    [Header("Força")]
    [SerializeField]
    private float força;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody rigidbody = hit.collider.attachedRigidbody;

        if(rigidbody != null)
        {
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();

            rigidbody.AddForceAtPosition(forceDirection * força, transform.position, ForceMode.Impulse);
        }
    }
}
