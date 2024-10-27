using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2_movement : MonoBehaviour
{
    public bool move = false;
    public Transform Target;
    public int speed = 6;
    public Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            animator.SetTrigger("walk");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            move = true;
        }
    }
}
