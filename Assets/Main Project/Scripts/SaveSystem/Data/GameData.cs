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
    public bool section1;
    public GameData()
    {
        tutorial = false;
        puzzleMulherPura = false;
        puzzleComoMata = false;
        puzzleOndeDorme = false;
        puzzleRatosAmigos = false;
        oQueCome = false;
        playerPosition = Vector3.zero;
    }
}
