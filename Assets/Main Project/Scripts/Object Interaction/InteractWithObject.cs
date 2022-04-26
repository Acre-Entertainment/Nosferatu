using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractWithObject : MonoBehaviour
{
    public GameObject playerDetectArea;
    private DetectNearbyObjects detectNearbyObjects;
    private InfoKeeper infoKeeper;
    void Start()
    {
        detectNearbyObjects = playerDetectArea.GetComponent<DetectNearbyObjects>();
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }

    void Update()
    {
        //mude aki o botão de interação
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return) && detectNearbyObjects.detectedGameObject != null && infoKeeper.gameIsBlockingInteraction == false)
        {
            detectNearbyObjects.detectedGameObject.GetComponent<ObjectEvent>().onInteraction.Invoke();
        }
    }
}
