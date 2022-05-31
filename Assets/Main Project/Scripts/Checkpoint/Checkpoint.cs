using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Checkpoint : MonoBehaviour
{
    public GameObject player;
    public GameObject[] checkPoints;
    public Vector3 point;
    private int newCheckPoint;
    // Start is called before the first frame update
    void Start()
    {        
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(newCheckPoint == 0)
        {
            point = new Vector3(18.7f, 7f, -56f);
        }
        else if(newCheckPoint == 1)
        {
            point = checkPoints[0].transform.position;
        }
        else if(newCheckPoint == 2)
        {
            point = checkPoints[1].transform.position;
        }
        else if (newCheckPoint == 3)
        {
            point = checkPoints[2].transform.position;
        }
    }

    public void Spawn()
    {
        player.transform.position = point;
    }

    public void Checkpoint1()
    {
        newCheckPoint = 1;
    }

    public void Checkpoint2()
    {
        newCheckPoint = 2;
    }

    public void Checkpoint3()
    {
        newCheckPoint = 3;
    }
}
