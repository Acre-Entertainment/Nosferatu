using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Checkpoint : MonoBehaviour
{
    public bool hasSaved;
    public GameObject player;
    public InfoKeeper infoKeeper;
    InfoKeeper savedInfokeeper;
    public Vector3 point;



    void Awake()
    {
        if(GameObject.FindGameObjectWithTag("Checkpoint"))
        {
            Destroy(gameObject);
        }
        else
        gameObject.tag = "Checkpoint";
    }
    void Start()
    {
        seekOutScene();
    }

    void onSceneStart()
    {
        seekOutScene();
        if(hasSaved == true)
        {
            Load();
            Spawn();
            GameObject.FindGameObjectWithTag("GameMaster").GetComponent<SetThings>().SetThingsAccordingToSave();
        }
    }
    public void seekOutScene()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }
        public void Spawn()
    {
        player.transform.position = point;
    }
    public void Save()
    {
        point = player.transform.position;
        savedInfokeeper = infoKeeper;
        hasSaved = true;
    }
    public void Load()
    {
        player.transform.position = point;
        infoKeeper = savedInfokeeper;
    }
}
