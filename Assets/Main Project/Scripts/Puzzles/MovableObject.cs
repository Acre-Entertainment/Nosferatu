using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour
{
    public bool active;
    private GameObject carrier;
    private GameObject originalParent;
    private Vector3 positionRelativeToParent;
    public float parentBuffer;
    //bounds usa a posição local, n global
    //public float XLowerBound, XUpperBound, YLowerBound, YUpperBound, ZLowerBound, ZUpperBound, boundCorrection;
    private void Start() {
        originalParent = gameObject.transform.parent.gameObject;
    }
    private void Update()
    {
        if(active == true )
        {
            if(gameObject.transform.localPosition != positionRelativeToParent)
            {
                if(gameObject.transform.localPosition.x > positionRelativeToParent.x + parentBuffer || gameObject.transform.localPosition.x < positionRelativeToParent.x - parentBuffer || gameObject.transform.localPosition.y > positionRelativeToParent.y + parentBuffer || gameObject.transform.localPosition.y < positionRelativeToParent.y - parentBuffer || gameObject.transform.localPosition.z > positionRelativeToParent.z + parentBuffer || gameObject.transform.localPosition.z < positionRelativeToParent.z - parentBuffer)
                {
                    setActiveFalse();
                }
            }
    
            if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                setActiveFalse();
            }
        }
    }
    public void setActiveOn(GameObject CR)
    {
        carrier = CR;
        active = true;
        carrier.GetComponent<InteractWithObject>().enabled = false;
        carrier.GetComponent<PlayerMovement>().isCarrying = true;

        gameObject.transform.parent = carrier.transform;
        positionRelativeToParent = gameObject.transform.localPosition;

        //carrierFormerXPosition = carrier.transform.position.x;
        //carrierFormerYPosition = carrier.transform.position.y;
        //carrierFormerZPosition = carrier.transform.position.z;
    }
    public void setActiveFalse()
    {
        active = false;
        carrier.GetComponent<InteractWithObject>().enabled = true;
        carrier.GetComponent<PlayerMovement>().isCarrying = false;

        gameObject.transform.parent = originalParent.transform;
    }
    private void OnTriggerExit(Collider other) {
        if(other.tag == "Detected Area" && active == true)
        {
            setActiveFalse();
        }
    }
}
