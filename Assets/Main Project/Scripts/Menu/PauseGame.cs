using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public static bool isPause = false;
    public GameObject uiPause;
    // Start is called before the first frame update
    void Start()
    {
        if (isPause)
        {
            Pause();
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Esc para pausar ou voltar ao jogo
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    //Voltar ao Jogo
    public void Resume()
    {
        uiPause.SetActive(false);
        Time.timeScale = 1;
        isPause = false;
    }

    //Pausar o Jogo
    public void Pause()
    {
        uiPause.SetActive(true);
        Time.timeScale = 0;
        isPause = true;

    }

    //Ir para o menu
    public void Menu()
    {
        Resume();
        SceneManager.LoadScene("02_Menu");
    }
}
