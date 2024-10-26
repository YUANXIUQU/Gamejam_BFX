using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public bool move = false;
    public int speed = 6;
    Rigidbody2D rb;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(move)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            move = true;
            animator.SetFloat("xVelocity", MathF.Abs(rb.velocity.x));
        }
    }

    
}
