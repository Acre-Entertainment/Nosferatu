using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void MainGame()
    {
        //mudei temporariamente
        SceneManager.LoadScene("Test scene");
    }

    public void TestScene()
    {
        SceneManager.LoadScene("Test scene");
    }
       public void Menu()
    {
        SceneManager.LoadScene("02_Menu");
    }
    public void Sair()
    {
        //UnityEditor.EditorApplication.isPlaying = false; //Comentar quando for Buildar
        Application.Quit(); //Descomentar quando for Buildar
    }
}
