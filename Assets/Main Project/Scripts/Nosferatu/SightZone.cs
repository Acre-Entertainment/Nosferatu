using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SightZone : MonoBehaviour
{
    public GameObject player;
    public GameObject lastKnowPlayerLocation;
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
        direction = target - origin;
        ray = new Ray(origin, direction);

        if(Physics.Raycast(ray, out hit))
        {
            hittingthing = hit.collider.gameObject;
            if(hit.collider.gameObject.tag == "Player" && Vector3.Distance(origin, target) <= nosferatuSightRange)
            {
                nosferatuHasLineOfSight = true;
                lastKnowPlayerLocation.transform.position = player.transform.position;
            }
            else
            {
                nosferatuHasLineOfSight = false;
            }
        }
    }

}