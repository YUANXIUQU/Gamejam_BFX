using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endpoint : MonoBehaviour
{
    public bool endgame = false;
    void Update()
    {
        if(endgame)
        {
            Time.timeScale = 0;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            endgame = true;
           
        }
    }
}
