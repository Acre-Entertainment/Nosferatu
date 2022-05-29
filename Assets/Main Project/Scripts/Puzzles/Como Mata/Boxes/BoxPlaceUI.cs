using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BoxPlaceUI : MonoBehaviour
{
    InfoKeeper infoKeeper;
    public BoxPuzzleIsDone boxPuzzleIsDone;
    [HideInInspector] public BoxPlace boxPlace;
    public GameObject metalButton, clayButton, woodButton, currentButton;
    public TextMeshProUGUI currentButtonText;
    string currentMaterial;
    void Awake()
    {
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }
    void OnEnable()
    {
        resetButtons();
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            gameObject.SetActive(false);
            Time.timeScale = 1;
            boxPuzzleIsDone.checkPuzzle();
        }
    }
    public void pressedButton(int but)
    {
        switch(but)
        {
            case 1:
                infoKeeper.hasMataMetalBox = false;
                boxPlace.hasMetalBox = true;
                switch(boxPlace.whichBoxPlace)
                {
                    case 1: infoKeeper.metalBoxIn1 = true; break;
                    case 2: infoKeeper.metalBoxIn2 = true; break;
                    case 3: infoKeeper.metalBoxIn3 = true; break;
                }
                break;
            case 2:
                infoKeeper.hasMataClayBox = false;
                boxPlace.hasClayBox = true;
                switch(boxPlace.whichBoxPlace)
                {
                    case 1: infoKeeper.clayBoxIn1 = true; break;
                    case 2: infoKeeper.clayBoxIn2 = true; break;
                    case 3: infoKeeper.clayBoxIn3 = true; break;
                }
                break;
            case 3:
                infoKeeper.hasMataWoodBox = false;
                boxPlace.hasWoodBox = true;
                switch(boxPlace.whichBoxPlace)
                {
                    case 1: infoKeeper.woodBoxIn1 = true; break;
                    case 2: infoKeeper.woodBoxIn2 = true; break;
                    case 3: infoKeeper.woodBoxIn3 = true; break;
                }
                break;
            case 4:
                switch(currentMaterial)
                {
                    case "Metal":
                        infoKeeper.hasMataMetalBox = true;
                        boxPlace.hasWoodBox = false;
                        switch(boxPlace.whichBoxPlace)
                        {
                            case 1: infoKeeper.metalBoxIn1 = false; break;
                            case 2: infoKeeper.metalBoxIn2 = false; break;
                            case 3: infoKeeper.metalBoxIn3 = false; break;
                        }
                        break;
                    case "Clay":
                        infoKeeper.hasMataClayBox = true;
                        boxPlace.hasClayBox = false;
                        switch(boxPlace.whichBoxPlace)
                        {
                            case 1: infoKeeper.clayBoxIn1 = false; break;
                            case 2: infoKeeper.clayBoxIn2 = false; break;
                            case 3: infoKeeper.clayBoxIn3 = false; break;
                        }
                        break;
                    case "Wood":
                        infoKeeper.hasMataWoodBox = true;
                        boxPlace.hasWoodBox = false;
                        switch(boxPlace.whichBoxPlace)
                        {
                            case 1: infoKeeper.woodBoxIn1 = false; break;
                            case 2: infoKeeper.woodBoxIn2 = false; break;
                            case 3: infoKeeper.woodBoxIn3 = false; break;
                        }
                        break;
                }
                break;
        }
        resetButtons();
    }

    void resetButtons()
    {
        if(infoKeeper.hasMataMetalBox == true){metalButton.SetActive(true);}else{metalButton.SetActive(false);}
        if(infoKeeper.hasMataClayBox == true){clayButton.SetActive(true);}else{clayButton.SetActive(false);}
        if(infoKeeper.hasMataWoodBox == true){woodButton.SetActive(true);}else{woodButton.SetActive(false);}

        if(boxPlace.hasMetalBox == true || boxPlace.hasClayBox == true || boxPlace.hasWoodBox == true)
        {
            currentButton.SetActive(true);
            metalButton.SetActive(false);
            clayButton.SetActive(false);
            woodButton.SetActive(false);
        }
        else
        {
            currentButton.SetActive(false);
        }

        if(boxPlace.hasMetalBox == true){currentButtonText.text = "Metal Box"; currentMaterial = "Metal";}
        if(boxPlace.hasClayBox == true){currentButtonText.text = "Clay Box"; currentMaterial = "Clay";}
        if(boxPlace.hasWoodBox == true){currentButtonText.text = "Wood Box"; currentMaterial = "Wood";}
    }
}
