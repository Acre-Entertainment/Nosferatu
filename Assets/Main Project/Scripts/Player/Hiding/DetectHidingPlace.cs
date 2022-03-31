using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectHidingPlace : MonoBehaviour
{
    public bool isInContactWithHidingPlace;
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cama" || other.tag == "Mesa" || other.tag == "Cortina" || other.tag == "Barril")
        {
            isInContactWithHidingPlace = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "Cama" || other.tag == "Mesa" || other.tag == "Cortina" || other.tag == "Barril")
        {
            isInContactWithHidingPlace = false;
        }
    }
}
