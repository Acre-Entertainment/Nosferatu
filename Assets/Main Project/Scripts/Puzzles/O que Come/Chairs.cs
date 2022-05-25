using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chairs : MonoBehaviour
{
    public GameObject chair;
    public float chairPositionx1, chairPositionx2, chairPositionx3, chairPositionz1, chairPositionz2, chairPositionz3;
    public int chairRotation1, chairRotation2, chairRotation3;
    public int chairPosition;
    public int correctPosition;
    public bool chairIsOk;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.C))
        {
            changeChair();
        }

        if(correctPosition == chairPosition)
        {
            chairIsOk = true;
        }
        else
        {
            chairIsOk = false;
        }
    }

    public void changeChair()
    {
        chairPosition++;
        if (chairPosition > 3)
        {
            chairPosition = 1;
        }
        switch (chairPosition)
        {
            case 1:
                chair.transform.localPosition = new Vector3(chairPositionx1, transform.localPosition.y, chairPositionz1);
                chair.transform.Rotate(new Vector3(x: 0, y: chairRotation1, z: 0));
                break;
            case 2:
                chair.transform.localPosition = new Vector3(chairPositionx2, transform.localPosition.y, chairPositionz2);
                chair.transform.Rotate(new Vector3(x: 0, y: chairRotation2, z: 0));
                break;
            case 3:
                chair.transform.localPosition = new Vector3(chairPositionx3, transform.localPosition.y, chairPositionz3);
                chair.transform.Rotate(new Vector3(x: 0, y: chairRotation3, z: 0));
                break;
            default:
                chair.transform.localPosition = new Vector3(chairPositionx1, transform.localPosition.y, chairPositionz1);
                chair.transform.Rotate(new Vector3(x: 0, y: chairRotation1, z: 0));
                break;
        }
    }
}
