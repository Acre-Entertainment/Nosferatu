using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Checkpoint : MonoBehaviour, IDataPersistance
{
    //public bool hasSaved;
    public GameObject player;
    public PlayerMovement playerMovement;
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
    public bool chest3, chest4;
    public GameObject tutorialKeys;
    public GameObject colliderTutorial;
    public GameObject tutorialScreen;
    public GameObject posTutorial;
    public TextBoxManager textBoxManager;

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

    [Header("Nosferatu")]
    public GameObject nosferatu;
    public bool nosferatuEnabled;
    public NavMeshAgent nosferatuAgent;
    public TreeStart nosferatuTreeStart;

    [Header("Cameras")]
    public GameObject[] cameras;
    public bool camera1 = true;
    public bool camera2;
    public bool camera3;
    public bool camera4;
    public bool camera5;
    public bool cameraPuzzleoqueCome;
    public bool cameraPuzzleComoMata;
    public bool cameraPuzzleMulherPura;
    public bool cameraPuzzleRatosAmigos;
    public bool cameraPuzzleOndeDorme;

    [Header("Doors")]
    public GameObject oQueComeDoor;
    public GameObject oQueComeDoor2;
    public MulherPura mulherPura;
    public ComoMata comoMata;
    public CM_checkThreeKeyHole ondeDorme;
    public Animator doorOndeDorme;
    public CheckMesaTable ratosCompanheiros;
    public bool doorSection1;
    public GameObject lockedDoorSection1;
    public GameObject openedDoorSection1;
    public GameObject doorTutorial;
    public Animator doorComoMata;
    public Animator doorComoMata2;
    public Animator doorComoMata3;

    [Header("Bau")]
    public GameObject bauRato1;
    public GameObject bau2Rato1;
    public GameObject doorRato1;
    public GameObject door2Rato1;
    public GameObject bau1;
    public GameObject bau2;
    public GameObject doorBau1;
    public GameObject doorBau2;
    public GameObject bau3;
    public GameObject bau32;
    public GameObject doorbau3;
    public GameObject door2bau3;
    public Animator doorBau3;
    public GameObject bau4;
    public GameObject bau42;
    public GameObject doorbau4;
    public GameObject door2bau4;
    public Animator doorBau4;
    public Animator door2Bau4;

    public SetTimeScaleOnStart _timeScale;


    public void LoadData(GameData data)
    {
        //PauseGame.isPause = true;
        _timeScale.timeScale = 1;

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

        camera1 = data.camera1;
        camera2 = data.camera2;
        camera3 = data.camera3;
        camera4 = data.camera4;
        camera5 = data.camera5;
        cameraPuzzleoqueCome = data.cameraoqueCome;
        cameraPuzzleComoMata = data.cameraComoMata;
        cameraPuzzleMulherPura = data.cameraMulherPura;
        cameraPuzzleRatosAmigos = data.cameraRatosAmigos;
        cameraPuzzleOndeDorme = data.cameraOndeDorme;


        tutorialIsOver = data.tutorial;
        puzzleMulherPuraIsOver = data.puzzleMulherPura;
        puzzleComoMataOver = data.puzzleComoMata;
        puzzleOndeDormeIsOver = data.puzzleOndeDorme;
        puzzleRatosAmigosIsOver = data.puzzleRatosAmigos;
        puzzleOQueComeIsOver = data.oQueCome;
        hasRatoKey1 = data.hasRatoKey1;
        hasRatoKey2 = data.hasRatoKey2;
        chest3 = data.chest3;
        chest4 = data.chest4;

        doorSection1 = data.doorSection1;

        playerMovement.futureCameraDirection = data.playerDirection;

        if (tutorialIsOver)
        {
            tutorialKeys.SetActive(false);
            colliderTutorial.SetActive(false);
            doorTutorial.SetActive(true);
            tutorialScreen.SetActive(false);
            posTutorial.SetActive(true);
            textBoxManager.followUpText[1] = "";
        }

        if (puzzleOQueComeIsOver)
        {
            oQueComeDoor.SetActive(false);
            oQueComeDoor2.SetActive(true);
        }

        if (puzzleMulherPuraIsOver)
        {
            mulherPura.GetComponent<MulherPura>();
            mulherPura.hasFinishedPuzzle.Invoke();
        }

        if (puzzleComoMataOver)
        {
            doorComoMata.GetComponent<Animator>().enabled = true;
            doorComoMata2.GetComponent<Animator>().enabled = true;
            doorComoMata3.GetComponent<Animator>().enabled = true;
            comoMata.GetComponent<ComoMata>();
            //comoMata.onPuzzleComplete1.Invoke();
            comoMata.onPuzzleComplete2.Invoke();
        }

        if (puzzleOndeDormeIsOver)
        {
            ondeDorme.GetComponent<CM_checkThreeKeyHole>();
            ondeDorme.onPuzzleSolved.Invoke();
            doorOndeDorme.GetComponent<Animator>().enabled = true;
        }

        if (puzzleRatosAmigosIsOver)
        {
            ratosCompanheiros.GetComponent<CheckMesaTable>();
            ratosCompanheiros.onPuzzleComplete.Invoke();
        }

        if (hasRatoKey1)
        {
            bauRato1.SetActive(false);
            bau2Rato1.SetActive(true);
            doorRato1.SetActive(false);
            door2Rato1.SetActive(true);
        }

        if (hasRatoKey2)
        {
            bau1.SetActive(false);
            bau2.SetActive(true);
            doorBau1.SetActive(false);
            doorBau2.SetActive(true);
        }

        if (chest3)
        {
            bau3.SetActive(false);
            bau32.SetActive(true);
            doorbau3.SetActive(false);
            door2bau3.SetActive(true);
            doorBau3.GetComponent<Animator>().enabled = true;
        }

        if (chest4)
        {
            bau4.SetActive(false);
            bau42.SetActive(true);
            doorbau4.SetActive(false);
            door2bau4.SetActive(true);
            doorBau4.GetComponent<Animator>().enabled = true;
            door2Bau4.GetComponent<Animator>().enabled = true;
        }

        if (data.doorSection1)
        {
            lockedDoorSection1.SetActive(false);
            openedDoorSection1.SetActive(true);
        }

        if (data.playerPosition != Vector3.zero)
        {
            point = data.playerPosition;
        }

        nosferatuEnabled = data.nosferatu;
        

        seekOutScene();
        CheckSections();
        CheckCameras();
        Spawn();

        if (nosferatuEnabled)
        {
            EnableNosferatu();
        }

        StartCoroutine(StartGame());
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

        data.camera1 = camera1;
        data.camera2 = camera2;
        data.camera3 = camera3;
        data.camera4 = camera4;
        data.camera5 = camera5;
        data.cameraoqueCome = cameraPuzzleoqueCome;
        data.cameraComoMata = cameraPuzzleComoMata;
        data.cameraMulherPura = cameraPuzzleMulherPura;
        data.cameraRatosAmigos = cameraPuzzleRatosAmigos;
        data.cameraOndeDorme = cameraPuzzleOndeDorme;

        data.tutorial = tutorialIsOver;
        data.puzzleMulherPura = puzzleMulherPuraIsOver;
        data.puzzleComoMata = puzzleComoMataOver;
        data.puzzleOndeDorme = puzzleOndeDormeIsOver;
        data.puzzleRatosAmigos = puzzleRatosAmigosIsOver;
        data.oQueCome = puzzleOQueComeIsOver;
        data.playerPosition = point;

        data.hasRatoKey1 = hasRatoKey1;
        data.hasRatoKey2 = hasRatoKey2;
        data.chest3 = chest3;
        data.chest4 = chest4;

        data.doorSection1 = doorSection1;

        data.nosferatu = nosferatuEnabled;

        data.playerDirection = playerMovement.futureCameraDirection;
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
        Load();
    }
    public void Spawn()
    {
        player.transform.position = point;
        Debug.Log("Spawnado");
        player.GetComponent<PlayerMovement>().enabled = false;
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
        player.transform.position = point;
        infoKeeper.tutorialIsOver = tutorialIsOver;
        infoKeeper.puzzleMulherPuraIsOver = puzzleMulherPuraIsOver;
        infoKeeper.puzzleComoMataOver = puzzleComoMataOver;
        infoKeeper.puzzleOndeDormeIsOver = puzzleOndeDormeIsOver;
        infoKeeper.puzzleRatosAmigosIsOver = puzzleRatosAmigosIsOver;
        infoKeeper.puzzleOQueComeIsOver = puzzleOQueComeIsOver;
        infoKeeper.tutorialHasPlayedRat = tutorialHasPlayedRat;
        infoKeeper.tutorialHasCheckedDesk = tutorialHasCheckedDesk;
        infoKeeper.hasMulherPuraNote = hasMulherPuraNote;
        infoKeeper.hasBookA = hasBookA;
        infoKeeper.hasBookB = hasBookB;
        infoKeeper.hasBookC = hasBookC;
        infoKeeper.hasBookX = hasBookX;
        infoKeeper.hasBookY = hasBookY;
        infoKeeper.hasBookZ = hasBookZ;
        infoKeeper.placedBookA_1 = placedBookA_1;
        infoKeeper.placedBookB_1 = placedBookB_1;
        infoKeeper.placedBookC_1 = placedBookC_1;
        infoKeeper.placedBookX_1 = placedBookX_1;
        infoKeeper.placedBookY_1 = placedBookY_1;
        infoKeeper.placedBookZ_1 = placedBookZ_1;
        infoKeeper.placedBookA_2 = placedBookA_2;
        infoKeeper.placedBookB_2 = placedBookB_2;
        infoKeeper.placedBookC_2 = placedBookC_2;
        infoKeeper.placedBookX_2 = placedBookX_2;
        infoKeeper.placedBookY_2 = placedBookY_2;
        infoKeeper.placedBookZ_2 = placedBookZ_2;
        infoKeeper.castInventory = castInventory;
        infoKeeper.bookInventory = bookInventory;
        infoKeeper.hasMataMetalBox = hasMataMetalBox;
        infoKeeper.metalBoxIn1 = metalBoxIn1;
        infoKeeper.metalBoxIn2 = metalBoxIn2;
        infoKeeper.metalBoxIn3 = metalBoxIn3;
        infoKeeper.hasMataWoodBox = hasMataWoodBox;
        infoKeeper.woodBoxIn1 = woodBoxIn1;
        infoKeeper.woodBoxIn2 = woodBoxIn2;
        infoKeeper.woodBoxIn3 = woodBoxIn3;
        infoKeeper.hasMataClayBox = hasMataClayBox;
        infoKeeper.clayBoxIn1 = clayBoxIn1;
        infoKeeper.clayBoxIn2 = clayBoxIn2;
        infoKeeper.clayBoxIn3 = clayBoxIn3;
        infoKeeper.hasMataBroom = hasMataBroom;
        infoKeeper.hasMataBook = hasMataBook;
        infoKeeper.hasMataOpenedDoor = hasMataOpenedDoor;
        infoKeeper.hasDormeKey1 = hasDormeKey1;
        infoKeeper.hasDormeKey2 = hasDormeKey2;
        infoKeeper.hasDormeKey3 = hasDormeKey3;
        infoKeeper.hasDormeKey4 = hasDormeKey4;
        infoKeeper.hasDormeKey5 = hasDormeKey5;
        infoKeeper.ratoTablePosition1 = ratoTablePosition1;
        infoKeeper.ratoTablePosition2 = ratoTablePosition2;
        infoKeeper.ratoTablePosition3 = ratoTablePosition3;
        infoKeeper.hasRatoKey1 = hasRatoKey1;
        infoKeeper.hasRatoKey2 = hasRatoKey2;
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
                tutorialSection = false;
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

    public void EnableNosferatu()
    {
        nosferatuEnabled = true;
        nosferatu.SetActive(nosferatuEnabled);
        nosferatuAgent.speed = 5;
        nosferatuTreeStart.timeToSpawn = 60f;
        nosferatuTreeStart.timeUntilSpawn = 60f;
        nosferatuTreeStart.timeUntilDespawn = 30f;
    }

    public void ChangeCamera(string cameraName)
    {
        switch (cameraName)
        {
            case "camera1":
                camera1 = true;
                camera2 = false;
                camera3 = false;
                camera4 = false;
                camera5 = false;
                cameraPuzzleoqueCome = false;
                cameraPuzzleComoMata = false;
                cameraPuzzleMulherPura = false;
                cameraPuzzleRatosAmigos = false;
                cameraPuzzleOndeDorme = false;
                break;
            case "camera2":
                camera1 = false;
                camera2 = true;
                camera3 = false;
                camera4 = false;
                camera5 = false;
                cameraPuzzleoqueCome = false;
                cameraPuzzleComoMata = false;
                cameraPuzzleMulherPura = false;
                cameraPuzzleRatosAmigos = false;
                cameraPuzzleOndeDorme = false;
                break;
            case "camera3":
                camera1 = false;
                camera2 = false;
                camera3 = true;
                camera4 = false;
                camera5 = false;
                cameraPuzzleoqueCome = false;
                cameraPuzzleComoMata = false;
                cameraPuzzleMulherPura = false;
                cameraPuzzleRatosAmigos = false;
                cameraPuzzleOndeDorme = false;
                break;
            case "camera4":
                camera1 = false;
                camera2 = false;
                camera3 = false;
                camera4 = true;
                camera5 = false;
                cameraPuzzleoqueCome = false;
                cameraPuzzleComoMata = false;
                cameraPuzzleMulherPura = false;
                cameraPuzzleRatosAmigos = false;
                cameraPuzzleOndeDorme = false;
                break;
            case "camera5":
                camera1 = false;
                camera2 = false;
                camera3 = false;
                camera4 = false;
                camera5 = true;
                cameraPuzzleoqueCome = false;
                cameraPuzzleComoMata = false;
                cameraPuzzleMulherPura = false;
                cameraPuzzleRatosAmigos = false;
                cameraPuzzleOndeDorme = false;
                break;
            case "camera6":
                camera1 = false;
                camera2 = false;
                camera3 = false;
                camera4 = false;
                camera5 = false;
                cameraPuzzleoqueCome = true;
                cameraPuzzleComoMata = false;
                cameraPuzzleMulherPura = false;
                cameraPuzzleRatosAmigos = false;
                cameraPuzzleOndeDorme = false;
                break;
            case "camera7":
                camera1 = false;
                camera2 = false;
                camera3 = false;
                camera4 = false;
                camera5 = false;
                cameraPuzzleoqueCome = false;
                cameraPuzzleComoMata = true;
                cameraPuzzleMulherPura = false;
                cameraPuzzleRatosAmigos = false;
                cameraPuzzleOndeDorme = false;
                break;
            case "camera8":
                camera1 = false;
                camera2 = false;
                camera3 = false;
                camera4 = false;
                camera5 = false;
                cameraPuzzleoqueCome = false;
                cameraPuzzleComoMata = false;
                cameraPuzzleMulherPura = true;
                cameraPuzzleRatosAmigos = false;
                cameraPuzzleOndeDorme = false;
                break;
            case "camera9":
                camera1 = false;
                camera2 = false;
                camera3 = false;
                camera4 = false;
                camera5 = false;
                cameraPuzzleoqueCome = false;
                cameraPuzzleComoMata = false;
                cameraPuzzleMulherPura = false;
                cameraPuzzleRatosAmigos = true;
                cameraPuzzleOndeDorme = false;
                break;
            case "camera10":
                camera1 = false;
                camera2 = false;
                camera3 = false;
                camera4 = false;
                camera5 = false;
                cameraPuzzleoqueCome = false;
                cameraPuzzleComoMata = false;
                cameraPuzzleMulherPura = false;
                cameraPuzzleRatosAmigos = false;
                cameraPuzzleOndeDorme = true;
                break;
        }
    }

    public void CheckCameras()
    {
        if (camera1)
        {
            cameras[0].SetActive(true);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
            cameras[3].SetActive(false);
            cameras[4].SetActive(false);
            cameras[5].SetActive(false);
            cameras[6].SetActive(false);
            cameras[7].SetActive(false);
            cameras[8].SetActive(false);
            cameras[9].SetActive(false);
        }
        else if (camera2)
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(true);
            cameras[2].SetActive(false);
            cameras[3].SetActive(false);
            cameras[4].SetActive(false);
            cameras[5].SetActive(false);
            cameras[6].SetActive(false);
            cameras[7].SetActive(false);
            cameras[8].SetActive(false);
            cameras[9].SetActive(false);
        }
        else if (camera3)
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(true);
            cameras[3].SetActive(false);
            cameras[4].SetActive(false);
            cameras[5].SetActive(false);
            cameras[6].SetActive(false);
            cameras[7].SetActive(false);
            cameras[8].SetActive(false);
            cameras[9].SetActive(false);
        }
        else if (camera4)
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
            cameras[3].SetActive(true);
            cameras[4].SetActive(false);
            cameras[5].SetActive(false);
            cameras[6].SetActive(false);
            cameras[7].SetActive(false);
            cameras[8].SetActive(false);
            cameras[9].SetActive(false);
        }
        else if (camera5)
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
            cameras[3].SetActive(false);
            cameras[4].SetActive(true);
            cameras[5].SetActive(false);
            cameras[6].SetActive(false);
            cameras[7].SetActive(false);
            cameras[8].SetActive(false);
            cameras[9].SetActive(false);
        }
        else if (cameraPuzzleoqueCome)
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
            cameras[3].SetActive(false);
            cameras[4].SetActive(false);
            cameras[5].SetActive(true);
            cameras[6].SetActive(false);
            cameras[7].SetActive(false);
            cameras[8].SetActive(false);
            cameras[9].SetActive(false);
        }
        else if (cameraPuzzleComoMata)
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
            cameras[3].SetActive(false);
            cameras[4].SetActive(false);
            cameras[5].SetActive(false);
            cameras[6].SetActive(true);
            cameras[7].SetActive(false);
            cameras[8].SetActive(false);
            cameras[9].SetActive(false);
        }
        else if (cameraPuzzleMulherPura)
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
            cameras[3].SetActive(false);
            cameras[4].SetActive(false);
            cameras[5].SetActive(false);
            cameras[6].SetActive(false);
            cameras[7].SetActive(true);
            cameras[8].SetActive(false);
            cameras[9].SetActive(false);
        }
        else if (cameraPuzzleRatosAmigos)
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
            cameras[3].SetActive(false);
            cameras[4].SetActive(false);
            cameras[5].SetActive(false);
            cameras[6].SetActive(false);
            cameras[7].SetActive(false);
            cameras[8].SetActive(true);
            cameras[9].SetActive(false);
        }
        else if (cameraPuzzleOndeDorme)
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
            cameras[3].SetActive(false);
            cameras[4].SetActive(false);
            cameras[5].SetActive(false);
            cameras[6].SetActive(false);
            cameras[7].SetActive(false);
            cameras[8].SetActive(false);
            cameras[9].SetActive(true);
        }
    }

    public void Chest3()
    {
        chest3 = true;
    }

    public void Chest4()
    {
        chest4 = true;
    }

    public void DoorSection1()
    {
        doorSection1 = true;
    }

    IEnumerator StartGame()
    {
        yield return new WaitForSeconds(0.75f);
        player.GetComponent<PlayerMovement>().enabled = true;
    }
}
