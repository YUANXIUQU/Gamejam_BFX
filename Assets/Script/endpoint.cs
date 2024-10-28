using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endpoint : MonoBehaviour
{
    public GameObject end_level;
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
            end_level.SetActive(true);
        }
    }

    
}
