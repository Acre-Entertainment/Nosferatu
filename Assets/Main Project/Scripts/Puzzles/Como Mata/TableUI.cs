using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableUI : MonoBehaviour
{
    public GameObject button1, button2;
    public Table table;
    InfoKeeper InfoKeeper;
    public ComoMata comoMata;
    private void Awake() {
        InfoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }
    private void OnEnable() {
        if(InfoKeeper.castInventory > 0)
        {
            button1.SetActive(true);
        }
        else
        {
            button1.SetActive(false);
        }
        if(InfoKeeper.bookInventory > 0)
        {
            button2.SetActive(true);
        }
        else
        {
            button2.SetActive(false);
        }
    }
    private void Update() {
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            gameObject.SetActive(false);
            Time.timeScale = 1;
            
        }
    }
    public void onPress1()
    {
        InfoKeeper.castInventory--;
        table.hasCast = true;
        table.cast.SetActive(true);
        comoMata.checkAndAct1();

        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    public void onPress2()
    {
        InfoKeeper.bookInventory--;
        table.hasBook = true;
        table.book.SetActive(true);
        comoMata.checkAndAct1();

        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
