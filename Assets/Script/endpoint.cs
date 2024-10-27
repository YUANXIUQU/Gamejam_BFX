using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            Loadnextscene();
        }
    }

    void Loadnextscene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
