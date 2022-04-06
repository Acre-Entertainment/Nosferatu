using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToNextDialogue : MonoBehaviour
{
    TextBoxManager textBoxManager;
    void Start()
    {
        textBoxManager = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<TextBoxManager>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            textBoxManager.callnextText();
            Debug.Log("Call Next Tetx");
        }
    }
}
