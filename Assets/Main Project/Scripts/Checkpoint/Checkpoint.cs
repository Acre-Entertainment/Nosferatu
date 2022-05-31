using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public GameObject player;
    public GameObject[] checkPoints;
    public Vector3 point;
    private InfoKeeper infoKeeper;
    // Start is called before the first frame update
    void Start()
    {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn()
    {
        player.transform.position = point;
    }

    public void Checkpoint1()
    {
        point = checkPoints[0].transform.position;
    }

    public void Checkpoint2()
    {
        point = checkPoints[1].transform.position;
    }

    public void Checkpoint3()
    {
        point = checkPoints[2].transform.position;
    }
}
