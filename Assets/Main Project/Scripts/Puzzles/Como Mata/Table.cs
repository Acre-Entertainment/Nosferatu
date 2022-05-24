using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Table : MonoBehaviour
{
    InfoKeeper InfoKeeper;
    private void Start() {
        InfoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }
    public bool hasCast;
    public bool hasBook;
    public GameObject cast;
    public GameObject book;
    public GameObject tableUI;

    public void activateTable()
    {
        if(hasCast == true)
        {
            hasCast = false;
            cast.SetActive(false);
            InfoKeeper.castInventory++;
        }
        if(hasBook == true)
        {
            hasBook = false;
            book.SetActive(false);
            InfoKeeper.bookInventory++;
        }
        if(hasBook == false && hasCast == false)
        {
            tableUI.GetComponent<TableUI>().table = this;
            tableUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
