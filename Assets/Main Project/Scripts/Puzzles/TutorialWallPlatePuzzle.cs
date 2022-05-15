using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialWallPlatePuzzle : MonoBehaviour
{
    public GameObject plate1, plate2, plate3, plate4, door1, door2;
    public int plate2Position, plate3Position, plate4Position;
    public float level1Height, level2Height, level3Height;
    public bool preassurePlateIsPressed;
    private InfoKeeper infoKeeper;
    private void Start() {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
        plate1.GetComponent<ObjectEvent>().enabled = false;
        plate2.GetComponent<ObjectEvent>().enabled = false;
        plate3.GetComponent<ObjectEvent>().enabled = false;
        plate4.GetComponent<ObjectEvent>().enabled = false;
    }

    public void changePlate2()
    {
        plate2Position++;
        if(plate2Position > 3)
        {
            plate2Position = 1;
        }
        switch(plate2Position)
        {
            case 1:
                plate2.transform.localPosition = new Vector3(plate2.transform.localPosition.x, level1Height, plate2.transform.localPosition.z);
                break;
            case 2:
                plate2.transform.localPosition = new Vector3(plate2.transform.localPosition.x, level2Height, plate2.transform.localPosition.z);
                break;
            case 3:
                plate2.transform.localPosition = new Vector3(plate2.transform.localPosition.x, level3Height, plate2.transform.localPosition.z);
                break;
            default:
                plate2.transform.localPosition = new Vector3(plate2.transform.localPosition.x, level1Height, plate2.transform.localPosition.z);
                break;
        }
    }
    public void changePlate3()
    {
        plate3Position++;
        if(plate3Position > 3)
        {
            plate3Position = 1;
        }
        switch(plate3Position)
        {
            case 1:
                plate3.transform.localPosition = new Vector3(plate3.transform.localPosition.x, level1Height, plate3.transform.localPosition.z);
                break;
            case 2:
                plate3.transform.localPosition = new Vector3(plate3.transform.localPosition.x, level2Height, plate3.transform.localPosition.z);
                break;
            case 3:
                plate3.transform.localPosition = new Vector3(plate3.transform.localPosition.x, level3Height, plate3.transform.localPosition.z);
                break;
            default:
                plate3.transform.localPosition = new Vector3(plate3.transform.localPosition.x, level1Height, plate3.transform.localPosition.z);
                break;
        }
    }
    public void changePlate4()
    {
        plate4Position++;
        if(plate4Position > 3)
        {
            plate4Position = 1;
        }
        switch(plate4Position)
        {
            case 1:
                plate4.transform.localPosition = new Vector3(plate4.transform.localPosition.x, level1Height, plate4.transform.localPosition.z);
                break;
            case 2:
                plate4.transform.localPosition = new Vector3(plate4.transform.localPosition.x, level2Height, plate4.transform.localPosition.z);
                break;
            case 3:
                plate4.transform.localPosition = new Vector3(plate4.transform.localPosition.x, level3Height, plate4.transform.localPosition.z);
                break;
            default:
                plate4.transform.localPosition = new Vector3(plate4.transform.localPosition.x, level1Height, plate4.transform.localPosition.z);
                break;
        }
    }
    public void changePressurePlate(bool state)
    {
        preassurePlateIsPressed = state;
    }
}
