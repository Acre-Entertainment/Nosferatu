using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("CharacterController")]
    [SerializeField]
    private CharacterController controller;

    [Header("Velocidade")]
    [SerializeField]
    private float velocidade;
    [SerializeField]
    private float corrida;

    [Header("Gravidade")]
    [SerializeField]
    private float gravidade = -9.81f;

    private Vector3 movimentoInput;
    private Vector3 velocity;
    private bool run;
    public int currentDirection = 1;
    private int futureDirection = 1;
    public float cameraChangeControlDelay;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //ve a direção de movimento e aplica de acordo
        switch(currentDirection)
        {
            case 1:
                movimentoInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
                break;
            case 2:
                movimentoInput = new Vector3(Input.GetAxis("Vertical"), 0f, -Input.GetAxis("Horizontal"));
                break;
            case 3:
                movimentoInput = new Vector3(-Input.GetAxis("Horizontal"), 0f, -Input.GetAxis("Vertical"));
                break;
            case 4:
                movimentoInput = new Vector3(-Input.GetAxis("Vertical"), 0f, Input.GetAxis("Horizontal"));
                break;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            run = true;
        }
        else
        {
            run = false;
        }
        Movimento();
    }
    private void Movimento()
    {
        Vector3 MoveVector = transform.TransformDirection(movimentoInput);

        if (controller.isGrounded)
        {
            velocity.y = -1f;
        }
        else
        {
            velocity.y -= gravidade * -2f * Time.deltaTime;
        }
        if (run)
        {
            controller.Move(MoveVector * corrida * Time.deltaTime);
        }
        else
        {
            controller.Move(MoveVector * velocidade * Time.deltaTime);
        }
        controller.Move(velocity * Time.deltaTime);
    }
    public void setFutureDirection(int mov)
    {
        StopCoroutine(setCurrentDirection());
        futureDirection = mov;
        StartCoroutine(setCurrentDirection());
    }
    IEnumerator setCurrentDirection()
    {
        yield return new WaitForSeconds(cameraChangeControlDelay);
        currentDirection = futureDirection;
    }
}
