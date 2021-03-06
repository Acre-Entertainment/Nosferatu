using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("CharacterController")]
    [SerializeField]
    private CharacterController controller;

    [Header("Animator")]
    public Animator animator;

    [Header("HenryFix")]
    public HenryFix henryFix;

    [Header("Velocidade")]
    public float velocidade = 0;
    public float acceleration;
    public float deceleration;
    public float walkSpeedLimit;
    public float runSpeedLimit;
    public float carryingSpeedLimit;

    [Header("Gravidade")]
    [SerializeField]
    private float gravidade = -9.81f;

    public float rotationOffset;
    public float rotationOffsetSprint;
    public float rotationOffsetCarrying;

    private Vector3 movimentoInput;
    private Vector3 velocity;
    public bool walk;
    public bool run;
    public bool idle;
    public bool isCarrying;
    public float currentCameraDirection;
    public float futureCameraDirection ;
    public float cameraChangeSpeed;

    private Vector3 blankVector = new Vector3(0,0,0);
    void Update()
    {
        movimentoInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        if (Input.GetKey(KeyCode.LeftShift) && isCarrying == false)
        {
            run = true;
        }
        else
        {
            run = false;
        }
        
        if(!run)
        {
            if(isCarrying == true)
            {
                if(velocidade >= carryingSpeedLimit)
                {
                    velocidade = carryingSpeedLimit;
                }
            }
            else
            {
                if(velocidade >= walkSpeedLimit)
                {
                    velocidade = walkSpeedLimit;
                }
            }
        }
        else if(run)
        {
            if (velocidade >= runSpeedLimit)
            {
                velocidade = runSpeedLimit;
            }
        }
        if(velocidade <= 0)
        {
            velocidade = 0;
        }

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if(run)
            {
                velocidade += Time.deltaTime * acceleration;
                idle = false;
                walk = false;
                run = true;
            }
            else
            {
                velocidade += Time.deltaTime * acceleration;
                idle = false;
                walk = true;
                run = false;
            }
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



        if(futureCameraDirection != currentCameraDirection)
        {
            float cameraRotationAngle = futureCameraDirection - currentCameraDirection;
            if(cameraRotationAngle < 1 && cameraRotationAngle > -1)
            {
                currentCameraDirection = futureCameraDirection;
            }
            else
            {
                if(cameraRotationAngle >  180){cameraRotationAngle -= 360;}
                if(cameraRotationAngle < -180){cameraRotationAngle += 360;}
                if(cameraRotationAngle < 0){currentCameraDirection -= cameraChangeSpeed * Time.deltaTime;}
                if(cameraRotationAngle > 0){currentCameraDirection += cameraChangeSpeed * Time.deltaTime;}
                if(currentCameraDirection > 360){currentCameraDirection -= 360;}
                if(currentCameraDirection < 0){currentCameraDirection += 360;}
            }
        }



        if(isCarrying == true)
        {
            if(velocidade > 1 && !animator.GetBool("Push"))
            {
                animator.SetBool("Push", true);
                henryFix.ChangeValues(0, -0.5f, 0, 0, 0, 0);
            }
            if(velocidade < 1 && animator.GetBool("Push"))
            {
                animator.SetBool("Push", false);
                henryFix.ChangeValues(0, 0.5f, 0, 0, 0, 0);
            }
        }
        else if(animator.GetBool("Push"))
        {
            animator.SetBool("Push", false);
            henryFix.ChangeValues(0, 0.5f, 0, 0, 0, 0);
        }

        Movimento();
    }
    private void Movimento()
    {
        Vector3 MoveVector = transform.TransformDirection(movimentoInput);
        Vector3 MoveVectorWithCamera = Quaternion.AngleAxis(currentCameraDirection, Vector3.up) * MoveVector;
        Vector3 MoveVectorWithRotation = Quaternion.AngleAxis(gameObject.transform.localEulerAngles.y, Vector3.down) * MoveVectorWithCamera;

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
            controller.Move(MoveVectorWithRotation * velocidade * Time.deltaTime);
        }
        controller.Move(velocity * Time.deltaTime);



        if(MoveVectorWithRotation != blankVector && isCarrying == false)
        {
            float rotationAngle = Vector3.Angle(new Vector2(-1, 0), MoveVectorWithRotation);
            if(MoveVectorWithRotation.z < 0)
            {
                rotationAngle = 360 - rotationAngle;
            }
            if(run == true)
            {
                rotationAngle += rotationOffsetSprint;
            }
            else
            {
                rotationAngle += rotationOffset;
            }
            if(rotationAngle > 360){rotationAngle -= 360;}
            if(rotationAngle < 0){rotationAngle += 360;}
            gameObject.transform.localEulerAngles = new Vector3(0, rotationAngle, 0);
        }
        if(isCarrying == true)
        {
            Vector3 facingVector = Quaternion.AngleAxis(gameObject.transform.localEulerAngles.y - rotationOffsetCarrying, Vector3.up) * new Vector3(-1, 0, 0);
            float pushIntensity = Vector3.Angle(facingVector, MoveVectorWithRotation);
            animator.SetFloat("PushDirection", pushIntensity/180);
        }
    }
    public void setFutureDirection(float mov)
    {
        futureCameraDirection = mov;
    }
    public void setDirectionToPosition(Vector3 vec)
    {
        Vector3 vectionDirection = vec - gameObject.transform.position;
        float rotationAngle = Vector3.Angle(new Vector2(-1, 0), vectionDirection);
        if(vectionDirection.z < 0)
        {
            rotationAngle = 360 - rotationAngle;
        }
        if(rotationAngle > 360){rotationAngle -= 360;}
        if(rotationAngle < 0){rotationAngle += 360;}
        gameObject.transform.localEulerAngles = new Vector3(0, rotationAngle + rotationOffsetCarrying, 0);
    }
}
