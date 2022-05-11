using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractWithObject : MonoBehaviour
{
    public GameObject playerDetectArea;
    private DetectNearbyObjects detectNearbyObjects;
    private InfoKeeper infoKeeper;
    private TextBoxManager textBoxManager;
    void Start()
    {
        detectNearbyObjects = playerDetectArea.GetComponent<DetectNearbyObjects>();
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
        textBoxManager = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<TextBoxManager>();
    }

    void Update()
    {
        //mude aki o botão de interação
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return) && detectNearbyObjects.detectedGameObject != null && infoKeeper.gameIsBlockingInteraction == false)
        {
            ObjectEvent objectEvent = detectNearbyObjects.detectedGameObject.GetComponent<ObjectEvent>();
            objectEvent.onInteraction.Invoke();
            if(objectEvent.callDialogueBox == true)
            {
                int x = 0;
                foreach(string y in objectEvent.dialogueLines)
                {
                    textBoxManager.followUpText[x] = y;
                    x++;
                }
                textBoxManager.turnOnDialogueBox();
            }
        }
    }
}
