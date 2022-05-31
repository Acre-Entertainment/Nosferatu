using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Checkpoint : MonoBehaviour
{
    public bool hasSaved;
    public GameObject player;
    public InfoKeeper infoKeeper;
    public Vector3 point;



    void Awake()
    {
        if(GameObject.FindGameObjectWithTag("Checkpoint"))
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



    public bool tutorialIsOver;
    public bool puzzleMulherPuraIsOver;
    public bool puzzleComoMataOver;
    public bool puzzleOndeDormeIsOver;
    public bool puzzleRatosAmigosIsOver;
    public bool puzzle5IsOver;
    public bool puzzle6IsOver;
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



    public void Save()
    {
        point = player.transform.position;
        hasSaved = true;

        tutorialIsOver = infoKeeper.tutorialIsOver;
        puzzleMulherPuraIsOver = infoKeeper.puzzleMulherPuraIsOver;
        puzzleComoMataOver = infoKeeper.puzzleComoMataOver;
        puzzleOndeDormeIsOver = infoKeeper.puzzleOndeDormeIsOver;
        puzzleRatosAmigosIsOver = infoKeeper.puzzleRatosAmigosIsOver;
        puzzle5IsOver = infoKeeper.puzzle5IsOver;
        puzzle6IsOver = infoKeeper.puzzle6IsOver;
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
        player.transform.position = point;

        infoKeeper.tutorialIsOver = tutorialIsOver;
        infoKeeper.puzzleMulherPuraIsOver = puzzleMulherPuraIsOver;
        infoKeeper.puzzleComoMataOver = puzzleComoMataOver;
        infoKeeper.puzzleOndeDormeIsOver = puzzleOndeDormeIsOver;
        infoKeeper.puzzleRatosAmigosIsOver = puzzleRatosAmigosIsOver;
        infoKeeper.puzzle5IsOver = puzzle5IsOver;
        infoKeeper.puzzle6IsOver = puzzle6IsOver;
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
}
