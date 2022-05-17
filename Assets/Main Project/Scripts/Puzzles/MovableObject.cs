using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableObject : MonoBehaviour
{
    public bool active;
    private bool skipFirstFrame;
    private GameObject carrier;
    private float carrierFormerXPosition, carrierFormerYPosition, carrierFormerZPosition;
    private float XMovement, YMovement, ZMovement;
    //bounds usa a posição local, n global
    //public float XLowerBound, XUpperBound, YLowerBound, YUpperBound, ZLowerBound, ZUpperBound, boundCorrection;
    private void Update()
    {
        if(active == true )
        {
            XMovement = carrier.transform.position.x - carrierFormerXPosition;
            //Debug.Log(XMovement);
            YMovement = carrier.transform.position.y - carrierFormerYPosition;
            //Debug.Log(YMovement);
            ZMovement = carrier.transform.position.z - carrierFormerZPosition;
            //Debug.Log(ZMovement);

            gameObject.transform.position = new Vector3(gameObject.transform.position.x + XMovement, gameObject.transform.position.y + YMovement, gameObject.transform.position.z + ZMovement);
            //Debug.Log((gameObject.transform.localPosition) + "/" + (gameObject.transform.localPosition) + "/" + (gameObject.transform.localPosition));
            //if(gameObject.transform.localPosition.x < XLowerBound){gameObject.transform.localPosition = new Vector3(XLowerBound + boundCorrection, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z); setActiveFalse();}
            //if(gameObject.transform.localPosition.x > XUpperBound){gameObject.transform.localPosition = new Vector3(XUpperBound - boundCorrection, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z); setActiveFalse();}
            //if(gameObject.transform.localPosition.y < YLowerBound){gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, YLowerBound + boundCorrection, gameObject.transform.localPosition.z); setActiveFalse();}
            //if(gameObject.transform.localPosition.y > YUpperBound){gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, YUpperBound - boundCorrection, gameObject.transform.localPosition.z); setActiveFalse();}
            //if(gameObject.transform.localPosition.z < ZLowerBound){gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, ZLowerBound + boundCorrection); setActiveFalse();}
            //if(gameObject.transform.localPosition.z > ZUpperBound){gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, ZUpperBound - boundCorrection); setActiveFalse();}

            carrierFormerXPosition = carrier.transform.position.x;
            carrierFormerYPosition = carrier.transform.position.y;
            carrierFormerZPosition = carrier.transform.position.z;

            if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
            {
                setActiveFalse();
            }
        }
    }
    public void setActiveOn(GameObject CR)
    {
        carrier = CR;
        carrier.GetComponent<InteractWithObject>().enabled = true;

        active = true;
        carrier.GetComponent<InteractWithObject>().enabled = false;

        carrierFormerXPosition = carrier.transform.position.x;
        carrierFormerYPosition = carrier.transform.position.y;
        carrierFormerZPosition = carrier.transform.position.z;
    }
    public void setActiveFalse()
    {
        active = false;
        carrier.GetComponent<InteractWithObject>().enabled = true;
    }
    private void OnTriggerExit(Collider other) {
        if(other.tag == "Detected Area" && active == true)
        {
            setActiveFalse();
        }
    }
}
