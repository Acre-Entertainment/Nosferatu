using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithPuzzle : MonoBehaviour
{
    public GameObject playerDetectArea;
    private DetectedInteractableObjectTag detectedInteractableObjectTag;
    private CallAction callAction;
    private InfoKeeper infoKeeper;
    void Start()
    {
        detectedInteractableObjectTag = playerDetectArea.GetComponent<DetectedInteractableObjectTag>();
        callAction = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<CallAction>();
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }
    void Update()
    {
        //mude aki o botão de interação
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return) && detectedInteractableObjectTag.tagOfNearbyInteractableObject != "" && infoKeeper.gameIsBlockingInteraction == false)
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
            case "Puzzle_Bookstand_Door":
                callAction.Puzzle_Bookstand_Door();
                break;
            case "Puzzle_Fireplace_Desk_1":
                callAction.Puzzle_Fireplace_Desk_1();
                break;
            case "Puzzle_Fireplace_Desk_2":
                callAction.Puzzle_Fireplace_Desk_2();
                break;
            case "Puzzle_Fireplace_Bookstand":
                callAction.Puzzle_Fireplace_Bookstand();
                break;
            case "Puzzle_Fireplace_Chest":
                callAction.Puzzle_Fireplace_Chest();
                break;
            case "Puzzle_Fireplace_Table":
                callAction.Puzzle_Fireplace_Table();
                break;
            case "Puzzle_Fireplace_Chair_1":
                callAction.Puzzle_Fireplace_Chair_1();
                break;
            case "Puzzle_Fireplace_Chair_2":
                callAction.Puzzle_Fireplace_Chair_2();
                break;
            case "Puzzle_Fireplace_Chair_3":
                callAction.Puzzle_Fireplace_Chair_3();
                break;
            case "Puzzle_Fireplace_Door":
                callAction.Puzzle_Bookstand_Door();
                break;
            case "Puzzle_Basement_Entrance":
                callAction.Puzzle_Basement_Entrance();
                break;
            case "Puzzle_Basement_Skeleton":
                callAction.Puzzle_Basement_Skeleton();
                break;
            case "Puzzle_Basement_Chest_1":
                callAction.Puzzle_Basement_Chest_1();
                break;
            case "Puzzle_Basement_Chest_2":
                callAction.Puzzle_Basement_Chest_2();
                break;
        }

    }
}
