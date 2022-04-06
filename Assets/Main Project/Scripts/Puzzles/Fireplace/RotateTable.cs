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
                gameObject.transform.position = new Vector3(18, 2, -43);
                gameObject.transform.eulerAngles = new Vector3(0, 90, 0);
                break;
            case 2:
                gameObject.transform.position = new Vector3(16, 2, -42);
                gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
                break;
            case 3:
                gameObject.transform.position = new Vector3(18, 2, -39);
                gameObject.transform.eulerAngles = new Vector3(0, 270, 0);
                break;
            case 4:
                gameObject.transform.position = new Vector3(20, 2, -41);
                gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
                break;
        }
        infoKeeper.tableRotation++;
        if(infoKeeper.tableRotation == 5)
        {
            infoKeeper.tableRotation = 0;
        }
    }
}
