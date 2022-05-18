using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("CharacterController")]
    [SerializeField]
    private CharacterController controller;

    [Header("Velocidade")]
    public float velocidade = 0;
    public float acceleration;
    public float deceleration;

    [Header("Gravidade")]
    [SerializeField]
    private float gravidade = -9.81f;

    public float rotationSpeed;

    private Vector3 movimentoInput;
    private Vector3 velocity;
    public bool walk;
    public bool run;
    public bool idle;
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
            if (walk)
            {
                run = true;
            }
        }
        else
        {
            run = false;
        }
        
        if(!run)
        {
           if(velocidade >= 3)
            {
                velocidade = 3;
            }
        }
        else if(run)
        {
            if (velocidade >= 6)
            {
                velocidade = 6;
            }
        }
        if(velocidade <= 0)
        {
            velocidade = 0;
        }

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) && !run)
        {
            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) && run)
            {
                velocidade += Time.deltaTime * acceleration;
                idle = false;
                walk = false;
                run = true;
            }

            velocidade += Time.deltaTime * acceleration;
            idle = false;
            walk = true;
            run = false;
        }
        else
        {
            velocidade -= Time.deltaTime * deceleration;
            idle = true;
            walk = false;
            run = false;
        }

        if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            velocidade -= Time.deltaTime * deceleration;
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
        if (idle || walk || run)
        {
            controller.Move(MoveVector * velocidade * Time.deltaTime);
        }
        controller.Move(velocity * Time.deltaTime);

        if(MoveVector != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(MoveVector, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
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
