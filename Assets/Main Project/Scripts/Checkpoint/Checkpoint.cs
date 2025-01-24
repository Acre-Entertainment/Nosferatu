using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Checkpoint : MonoBehaviour, IDataPersistance
{
    //public bool hasSaved;
    public GameObject player;
    public InfoKeeper infoKeeper;
    public Vector3 point;


    public bool tutorialIsOver;
    public bool puzzleMulherPuraIsOver;
    public bool puzzleComoMataOver;
    public bool puzzleOndeDormeIsOver;
    public bool puzzleRatosAmigosIsOver;
    public bool puzzleOQueComeIsOver;
    public bool tutorialHasPlayedRat;
    public bool tutorialHasCheckedDesk;
    public bool hasMulherPuraNote;
    public bool hasBookA, hasBookB, hasBookC, hasBookX, hasBookY, hasBookZ;
    public bool placedBookA_1, placedBookB_1, placedBookC_1, placedBookX_1, placedBookY_1, placedBookZ_1;
    public bool placedBookA_2, placedBookB_2, placedBookC_2, placedBookX_2, placedBookY_2, placedBookZ_2;
    public int castInventory;
    public int bookInventory;
    public bool hasMataMetalBox, metalBoxIn1, metalBoxIn2, metalBoxIn3;
    public bool hasMataWoodBox, woodBoxIn1, woodBoxIn2, woodBoxIn3;
    public bool hasMataClayBox, clayBoxIn1, clayBoxIn2, clayBoxIn3;
    public bool hasMataBroom;
    public bool hasMataBook;
    public bool hasMataOpenedDoor;
    public bool hasDormeKey1, hasDormeKey2, hasDormeKey3, hasDormeKey4, hasDormeKey5;
    public int ratoTablePosition1, ratoTablePosition2, ratoTablePosition3;
    public bool hasRatoKey1, hasRatoKey2;

    [Header("Sections")]
    public bool tutorialSection;
    public bool section1;
    public bool section2;
    public bool section3;
    public bool section4;
    public bool section5;
    public bool section6;
    public bool section7;
    public bool section8;
    public bool section9;
    public bool section10;
    public bool section11;
    public bool section12;

    public GameObject[] section;

    public void LoadData(GameData data)
    {
        tutorialSection = data.tutorialSection;
        section1 = data.section1;
        section2 = data.section2;
        section3 = data.section3;
        section4 = data.section4;
        section5 = data.section5;
        section6 = data.section6;
        section7 = data.section7;
        section8 = data.section8;
        section9 = data.section9;
        section10 = data.section10;
        section11 = data.section11;
        section12 = data.section12;

        CheckSections();

        tutorialIsOver = data.tutorial;
        puzzleMulherPuraIsOver = data.puzzleMulherPura;
        puzzleComoMataOver = data.puzzleComoMata;
        puzzleOndeDormeIsOver = data.puzzleOndeDorme;
        puzzleRatosAmigosIsOver = data.puzzleRatosAmigos;
        puzzleOQueComeIsOver = data.oQueCome;
        if (data.playerPosition != Vector3.zero)
        {
            point = data.playerPosition;
        }
        Load();
        Spawn();
    }

    public void SaveData(GameData data)
    {
        data.tutorialSection = tutorialSection;
        data.section1 = section1;
        data.section2 = section2;
        data.section3 = section3;
        data.section4 = section4;
        data.section5 = section5;
        data.section6 = section6;
        data.section7 = section7;
        data.section8 = section8;
        data.section9 = section9;
        data.section10 = section10;
        data.section11 = section11;
        data.section12 = section12;

        data.tutorial = tutorialIsOver;
        data.puzzleMulherPura = puzzleMulherPuraIsOver;
        data.puzzleComoMata = puzzleComoMataOver;
        data.puzzleOndeDorme = puzzleOndeDormeIsOver;
        data.puzzleRatosAmigos = puzzleRatosAmigosIsOver;
        data.oQueCome = puzzleOQueComeIsOver;
        data.playerPosition = point;
    }

    void Awake()
    {
        if (GameObject.FindGameObjectWithTag("Checkpoint"))
        {
            Destroy(gameObject);
        }
        else
            gameObject.tag = "Checkpoint";
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        seekOutScene();
    }

    //void onSceneStart()
    //{
    //    seekOutScene();
    //    //if(hasSaved == true)
    //    //{
    //        Load();
    //        Spawn();
    //        GameObject.FindGameObjectWithTag("GameMaster").GetComponent<SetThings>().SetThingsAccordingToSave();
    //    //}
    //}
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
        //hasSaved = true;
        tutorialIsOver = infoKeeper.tutorialIsOver;
        puzzleMulherPuraIsOver = infoKeeper.puzzleMulherPuraIsOver;
        puzzleComoMataOver = infoKeeper.puzzleComoMataOver;
        puzzleOndeDormeIsOver = infoKeeper.puzzleOndeDormeIsOver;
        puzzleRatosAmigosIsOver = infoKeeper.puzzleRatosAmigosIsOver;
        puzzleOQueComeIsOver = infoKeeper.puzzleOQueComeIsOver;
        tutorialHasPlayedRat = infoKeeper.tutorialHasPlayedRat;
        tutorialHasCheckedDesk = infoKeeper.tutorialHasCheckedDesk;
        hasMulherPuraNote = infoKeeper.hasMulherPuraNote;
        hasBookA = infoKeeper.hasBookA;
        hasBookB = infoKeeper.hasBookB;
        hasBookC = infoKeeper.hasBookC;
        hasBookX = infoKeeper.hasBookX;
        hasBookY = infoKeeper.hasBookY;
        hasBookZ = infoKeeper.hasBookZ;
        placedBookA_1 = infoKeeper.placedBookA_1;
        placedBookB_1 = infoKeeper.placedBookB_1;
        placedBookC_1 = infoKeeper.placedBookC_1;
        placedBookX_1 = infoKeeper.placedBookX_1;
        placedBookY_1 = infoKeeper.placedBookY_1;
        placedBookZ_1 = infoKeeper.placedBookZ_1;
        placedBookA_2 = infoKeeper.placedBookA_2;
        placedBookB_2 = infoKeeper.placedBookB_2;
        placedBookC_2 = infoKeeper.placedBookC_2;
        placedBookX_2 = infoKeeper.placedBookX_2;
        placedBookY_2 = infoKeeper.placedBookY_2;
        placedBookZ_2 = infoKeeper.placedBookZ_2;
        castInventory = infoKeeper.castInventory;
        bookInventory = infoKeeper.bookInventory;
        hasMataMetalBox = infoKeeper.hasMataMetalBox;
        metalBoxIn1 = infoKeeper.metalBoxIn1;
        metalBoxIn2 = infoKeeper.metalBoxIn2;
        metalBoxIn3 = infoKeeper.metalBoxIn3;
        hasMataWoodBox = infoKeeper.hasMataWoodBox;
        woodBoxIn1 = infoKeeper.woodBoxIn1;
        woodBoxIn2 = infoKeeper.woodBoxIn2;
        woodBoxIn3 = infoKeeper.woodBoxIn3;
        hasMataClayBox = infoKeeper.hasMataClayBox;
        clayBoxIn1 = infoKeeper.clayBoxIn1;
        clayBoxIn2 = infoKeeper.clayBoxIn2;
        clayBoxIn3 = infoKeeper.clayBoxIn3;
        hasMataBroom = infoKeeper.hasMataBroom;
        hasMataBook = infoKeeper.hasMataBook;
        hasMataOpenedDoor = infoKeeper.hasMataOpenedDoor;
        hasDormeKey1 = infoKeeper.hasDormeKey1;
        hasDormeKey2 = infoKeeper.hasDormeKey2;
        hasDormeKey3 = infoKeeper.hasDormeKey3;
        hasDormeKey4 = infoKeeper.hasDormeKey4;
        hasDormeKey5 = infoKeeper.hasDormeKey5;
        ratoTablePosition1 = infoKeeper.ratoTablePosition1;
        ratoTablePosition2 = infoKeeper.ratoTablePosition2;
        ratoTablePosition3 = infoKeeper.ratoTablePosition3;
        hasRatoKey1 = infoKeeper.hasRatoKey1;
        hasRatoKey2 = infoKeeper.hasRatoKey2;
    }
    public void Load()
    {
        seekOutScene();
        //player.transform.position = point;
        //infoKeeper.tutorialIsOver = tutorialIsOver;
        //infoKeeper.puzzleMulherPuraIsOver = puzzleMulherPuraIsOver;
        //infoKeeper.puzzleComoMataOver = puzzleComoMataOver;
        //infoKeeper.puzzleOndeDormeIsOver = puzzleOndeDormeIsOver;
        //infoKeeper.puzzleRatosAmigosIsOver = puzzleRatosAmigosIsOver;
        //infoKeeper.puzzleOQueComeIsOver = puzzleOQueComeIsOver;
        //infoKeeper.tutorialHasPlayedRat = tutorialHasPlayedRat;
        //infoKeeper.tutorialHasCheckedDesk = tutorialHasCheckedDesk;
        //infoKeeper.hasMulherPuraNote = hasMulherPuraNote;
        //infoKeeper.hasBookA = hasBookA;
        //infoKeeper.hasBookB = hasBookB;
        //infoKeeper.hasBookC = hasBookC;
        //infoKeeper.hasBookX = hasBookX;
        //infoKeeper.hasBookY = hasBookY;
        //infoKeeper.hasBookZ = hasBookZ;
        //infoKeeper.placedBookA_1 = placedBookA_1;
        //infoKeeper.placedBookB_1 = placedBookB_1;
        //infoKeeper.placedBookC_1 = placedBookC_1;
        //infoKeeper.placedBookX_1 = placedBookX_1;
        //infoKeeper.placedBookY_1 = placedBookY_1;
        //infoKeeper.placedBookZ_1 = placedBookZ_1;
        //infoKeeper.placedBookA_2 = placedBookA_2;
        //infoKeeper.placedBookB_2 = placedBookB_2;
        //infoKeeper.placedBookC_2 = placedBookC_2;
        //infoKeeper.placedBookX_2 = placedBookX_2;
        //infoKeeper.placedBookY_2 = placedBookY_2;
        //infoKeeper.placedBookZ_2 = placedBookZ_2;
        //infoKeeper.castInventory = castInventory;
        //infoKeeper.bookInventory = bookInventory;
        //infoKeeper.hasMataMetalBox = hasMataMetalBox;
        //infoKeeper.metalBoxIn1 = metalBoxIn1;
        //infoKeeper.metalBoxIn2 = metalBoxIn2;
        //infoKeeper.metalBoxIn3 = metalBoxIn3;
        //infoKeeper.hasMataWoodBox = hasMataWoodBox;
        //infoKeeper.woodBoxIn1 = woodBoxIn1;
        //infoKeeper.woodBoxIn2 = woodBoxIn2;
        //infoKeeper.woodBoxIn3 = woodBoxIn3;
        //infoKeeper.hasMataClayBox = hasMataClayBox;
        //infoKeeper.clayBoxIn1 = clayBoxIn1;
        //infoKeeper.clayBoxIn2 = clayBoxIn2;
        //infoKeeper.clayBoxIn3 = clayBoxIn3;
        //infoKeeper.hasMataBroom = hasMataBroom;
        //infoKeeper.hasMataBook = hasMataBook;
        //infoKeeper.hasMataOpenedDoor = hasMataOpenedDoor;
        //infoKeeper.hasDormeKey1 = hasDormeKey1;
        //infoKeeper.hasDormeKey2 = hasDormeKey2;
        //infoKeeper.hasDormeKey3 = hasDormeKey3;
        //infoKeeper.hasDormeKey4 = hasDormeKey4;
        //infoKeeper.hasDormeKey5 = hasDormeKey5;
        //infoKeeper.ratoTablePosition1 = ratoTablePosition1;
        //infoKeeper.ratoTablePosition2 = ratoTablePosition2;
        //infoKeeper.ratoTablePosition3 = ratoTablePosition3;
        //infoKeeper.hasRatoKey1 = hasRatoKey1;
        //infoKeeper.hasRatoKey2 = hasRatoKey2;
    }

    public void ActiveSection(string section)
    {
        switch (section)
        {
            case "tutorialSection":
                tutorialSection = true;
                break;
            case "section1":
                section1 = true;
                break;
            case "section2":
                section2 = true;
                break;
            case "section3":
                section3 = true;
                break;
            case "section4":
                section4 = true;
                break;
            case "section5":
                section5 = true;
                break;
            case "section6":
                section6 = true;
                break;
            case "section7":
                section7 = true;
                break;
            case "section8":
                section8 = true;
                break;
            case "section9":
                section9 = true;
                break;
            case "section10":
                section10 = true;
                break;
            case "section11":
                section11 = true;
                break;
            case "section12":
                section12 = true;
                break;
        }
    }

    public void DeactiveSection(string section)
    {
        switch (section)
        {
            case "tutorialSection":
                tutorialSection = true;
                break;
            case "section1":
                section1 = false;
                break;
            case "section2":
                section2 = false;
                break;
            case "section3":
                section3 = false;
                break;
            case "section4":
                section4 = false;
                break;
            case "section5":
                section5 = false;
                break;
            case "section6":
                section6 = false;
                break;
            case "section7":
                section7 = false;
                break;
            case "section8":
                section8 = false;
                break;
            case "section9":
                section9 = false;
                break;
            case "section10":
                section10 = false;
                break;
            case "section11":
                section11 = false;
                break;
            case "section12":
                section12 = false;
                break;
        }
    }

    private void CheckSections()
    {
        section[0].SetActive(tutorialSection);
        section[1].SetActive(section1);
        section[2].SetActive(section2);
        section[3].SetActive(section3);
        section[4].SetActive(section4);
        section[5].SetActive(section5);
        section[6].SetActive(section6);
        section[7].SetActive(section7);
        section[8].SetActive(section8);
        section[9].SetActive(section9);
        section[10].SetActive(section10);
        section[11].SetActive(section11);
        section[12].SetActive(section12);
    }
}
