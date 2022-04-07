using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTable : MonoBehaviour
{
    //gira a mesa. Harcoded para o lugar da mesa atual, eu mudo depois
    InfoKeeper infoKeeper;
    void Start()
    {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }
    public void Rotate()
    {
        switch(infoKeeper.tableRotation)
        {
            case 1:
                gameObject.transform.position = new Vector3(19.75f, 2, -41.25f);
                gameObject.transform.Rotate(0, 90, 0, Space.World);
                break;
            case 2:
                gameObject.transform.position = new Vector3(17.5f, 2, -39);
                gameObject.transform.Rotate(0, 90, 0, Space.World);
                break;
            case 3:
                gameObject.transform.position = new Vector3(19.75f, 2, -36.75f);
                gameObject.transform.Rotate(0, 90, 0, Space.World);
                break;
            case 4:
                gameObject.transform.position = new Vector3(22, 2, -39);
                gameObject.transform.Rotate(0, 90, 0, Space.World);
                break;
        }
        infoKeeper.tableRotation++;
        if(infoKeeper.tableRotation == 5)
        {
            infoKeeper.tableRotation = 1;
        }
    }
}
