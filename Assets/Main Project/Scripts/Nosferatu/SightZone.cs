using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightZone : MonoBehaviour
{
    public GameObject player;
    public float nosferatuSightRange = 20;
    public bool nosferatuHasLineOfSight;
    public GameObject hittingthing;
    Ray ray;
    RaycastHit hit;
    Vector3 origin, target, direction;
    void Update()
    {
        origin = gameObject.transform.position;
        target = player.transform.position;
        direction = origin - target;
        ray = new Ray(origin, direction);
        if(Physics.Raycast(ray, out hit))
        {
            hittingthing = hit.collider.gameObject;
            if(hit.collider.gameObject.tag == "Player")
            {
                nosferatuHasLineOfSight = true;
            }
            else
            {
                nosferatuHasLineOfSight = false;
            }
        }
    }

}