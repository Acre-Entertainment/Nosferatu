using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool isInventory;
    public GameObject panelInventory;

    public bool aba1Bool;
    public bool aba2Bool;
    public GameObject aba1;
    public GameObject aba2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //tecla E para abrir o inventário
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (isInventory)
            {
                isInventory = false;
                panelInventory.SetActive(false);
            }
            else
            {
                isInventory = true;
                panelInventory.SetActive(true);
            }
        }
    }

    public void Aba1()
    {
        aba1.SetActive(true);
        aba2.SetActive(false);
    }

    public void Aba2()
    {
        aba2.SetActive(true);
        aba1.SetActive(false);
    }
}
