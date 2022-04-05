using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithPuzzle : MonoBehaviour
{
    public GameObject playerDetectArea;
    private DetectedInteractableObjectTag detectedInteractableObjectTag;
    private CallAction callAction;
    void Start()
    {
        detectedInteractableObjectTag = playerDetectArea.GetComponent<DetectedInteractableObjectTag>();
        callAction = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<CallAction>();
    }
    void Update()
    {
        //mude aki o botão de interação
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return) && detectedInteractableObjectTag.tagOfNearbyInteractableObject != "")
        {
            SortThroughObjects();
        }
    }
    //cheka a tag do objeto e chama uma função do CallAction apropriado
    void SortThroughObjects()
    {
        switch(detectedInteractableObjectTag.tagOfNearbyInteractableObject)
        {
            case "Puzzle_Bookstand_1":
                callAction.Puzzle_Bookstand_1();
                break;
            case "Puzzle_Bookstand_2":
                callAction.Puzzle_Bookstand_2();
                break;
            case "Puzzle_Bookstand_3":
                callAction.Puzzle_Bookstand_3();
                break;
            
        }

    }
}
