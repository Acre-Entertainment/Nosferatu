using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hide : MonoBehaviour
{
    //verifica se tem uma area de se esconder perto. Se sim, desativa o jogador e ativa o hiding GameObject
    //provalvemente vou mudar como funciona isso apos o J1
    public GameObject playerDetectArea;
    private DetectHidingPlace detectHidingPlace;
    public UnityEvent onHide;
    private InfoKeeper infoKeeper;
    void Start()
    {
        detectHidingPlace = playerDetectArea.GetComponent<DetectHidingPlace>();
        infoKeeper = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<InfoKeeper>();
    }
    void Update()
    {
        //pode mudar o botão pra se esconder aki
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return) && infoKeeper.gameIsBlockingInteraction == false)
        {
            checkIfHidingPlaceNearby();
        }
    }
    void checkIfHidingPlaceNearby()
    {
        if(detectHidingPlace.isInContactWithHidingPlace == true)
        {
            //Invoka o fim do 
            onHide.Invoke();
        }
    }
}
