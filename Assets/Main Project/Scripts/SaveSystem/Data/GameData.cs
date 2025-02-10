using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public Vector3 playerPosition;
    public bool tutorial;
    public bool puzzleMulherPura;
    public bool puzzleComoMata;
    public bool puzzleOndeDorme;
    public bool puzzleRatosAmigos;
    public bool oQueCome;

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

    public bool camera1 = true;
    public bool camera2;
    public bool camera3;
    public bool camera4;
    public bool camera5;

    public bool hasRatoKey1;
    public bool hasRatoKey2;
    public bool chest3;
    public bool chest4;

    public bool doorSection1;

    public bool nosferatu;
    public GameData()
    {
        tutorial = false;
        puzzleMulherPura = false;
        puzzleComoMata = false;
        puzzleOndeDorme = false;
        puzzleRatosAmigos = false;
        oQueCome = false;
        playerPosition = Vector3.zero;
        tutorialSection = true;
        section1 = false;
        section2 = false;
        section3 = false;
        section4 = false;
        section5 = false;
        section6 = false;
        section7 = false;
        section8 = false;
        section9 = false;
        section10 = false;
        section11 = false;
        section12 = false;
        nosferatu = false;
        camera1 = true;
        camera2 = false;
        camera3 = false;
        camera4 = false;
        camera5 = false;
        hasRatoKey1 = false;
        hasRatoKey2 = false;
        chest3 = false;
        chest4 = false;
        doorSection1 = false;
    }
}
