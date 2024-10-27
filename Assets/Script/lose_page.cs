using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lose_page : MonoBehaviour
{
    public GameObject page;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Replay()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
        page.SetActive(false);
    }

    public void backtoMenu()
    {
        SceneManager.LoadScene(0);
        page.SetActive(false);
    }
}
