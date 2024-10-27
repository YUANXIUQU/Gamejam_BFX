using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    public bool move = false;
    public int speed = 6;
    public Animator animator;
    public Transform[] targetpos; 
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(move)
        {
            if (targetpos.Length > 0)
            {
                transform.position = Vector3.MoveTowards(transform.position, targetpos[0].position,
                    speed * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
            
            animator.SetTrigger("walk");
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            move = true;
        }
        
    }

    
}
