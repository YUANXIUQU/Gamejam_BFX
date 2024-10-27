using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamestate : MonoBehaviour // see if game continues or stop
{
    public bool onwater = false;
    public bool onwood = false;
    private int woodCounter = 0;
    public bool playwoodsound = false;
    public bool playwatersound = false;
    public AudioSource walkboard;
    public AudioSource inwater;
    public GameObject lose_page;

    void Update()
    {
        if (onwater && onwood)
        {
            // game continues 
            Time.timeScale = 1;
            if(!playwoodsound)
            {
                walkboard.Play();
                playwoodsound = true;
            }
        }
        
        else if (onwater && !onwood)
        {
            // player is on water without wood
            Time.timeScale = 0;
            lose_page.SetActive(true);
            if (!playwatersound)
            {
                inwater.Play();
                playwatersound = true;
                walkboard.Stop();
            }
        }

        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("water"))
        {
            onwater = true;
        }
        else if (other.CompareTag("wood"))
        {
            woodCounter++; 
            onwood = true; 
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("water"))
        {
            onwater = false;
        }
        else if (other.CompareTag("wood"))
        {
            woodCounter--; 
            if (woodCounter <= 0)
            {
                onwood = false;
            }
        }
    }
}
