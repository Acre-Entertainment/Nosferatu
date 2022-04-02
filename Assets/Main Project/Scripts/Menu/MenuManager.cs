using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainGame()
    {
        SceneManager.LoadScene("Main Game");
    }

    public void Sair()
    {
        UnityEditor.EditorApplication.isPlaying = false; //Comentar quando for Buildar
        //Application.Quit(); //Descomentar quando for Buildar
    }
}
