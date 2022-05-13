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
    public float XLowerBound, XUpperBound, YLowerBound, YUpperBound, ZLowerBound, ZUpperBound;
    private void Update()
    {
        if(active == true )
        {
            XMovement = carrier.transform.position.x - carrierFormerXPosition;
            YMovement = carrier.transform.position.y - carrierFormerYPosition;
            ZMovement = carrier.transform.position.z - carrierFormerZPosition;

            gameObject.transform.position = new Vector3(gameObject.transform.position.x + XMovement, gameObject.transform.position.y + YMovement, gameObject.transform.position.z + ZMovement);

            if(gameObject.transform.localPosition.x < XLowerBound){gameObject.transform.localPosition = new Vector3(XLowerBound, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z);}
            if(gameObject.transform.localPosition.x > XUpperBound){gameObject.transform.localPosition = new Vector3(XUpperBound, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z);}
            if(gameObject.transform.localPosition.x < YLowerBound){gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, YLowerBound, gameObject.transform.localPosition.z);}
            if(gameObject.transform.localPosition.x > YUpperBound){gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, YUpperBound, gameObject.transform.localPosition.z);}
            if(gameObject.transform.localPosition.x < ZLowerBound){gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, ZLowerBound);}
            if(gameObject.transform.localPosition.x > ZUpperBound){gameObject.transform.localPosition = new Vector3(gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, ZUpperBound);}

            carrierFormerXPosition = carrier.transform.position.x;
            carrierFormerYPosition = carrier.transform.position.y;
            carrierFormerZPosition = carrier.transform.position.z;
        }
    }
    public void setActiveOn(GameObject CR)
    {
        active = true;
        carrier = CR;

        carrierFormerXPosition = carrier.transform.position.x;
        carrierFormerYPosition = carrier.transform.position.y;
        carrierFormerZPosition = carrier.transform.position.z;
    }
    public void setActiveFalse()
    {
        active = false;
    }
}
