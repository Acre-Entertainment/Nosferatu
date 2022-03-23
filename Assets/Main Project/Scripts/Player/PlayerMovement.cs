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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimentoInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

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

    public void Movimento()
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
}
