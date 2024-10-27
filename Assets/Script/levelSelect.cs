using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelect : MonoBehaviour
{
    public int level;
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(level+1);
    }
}
