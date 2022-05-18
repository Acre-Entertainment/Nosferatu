using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenryAnimator : MonoBehaviour
{
    public Animator animator;

    public PlayerMovement henry;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Blend", Mathf.Abs(henry.velocidade));
    }
}
