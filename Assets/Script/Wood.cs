using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    public float speed;
    public bool stopmove;
    public static bool createnext;
    // Update is called once per frame
    void Start()
    {
        stopmove = false;
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            stopmove = true;
            createnext = true;
        }
        if(stopmove == false)
        {
            transform.Translate(Vector3.down * speed * speed * Time.deltaTime);
        }
  
    }
}
