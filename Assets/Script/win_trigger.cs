using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win_trigger : MonoBehaviour
{
    public GameObject win_page;
   
    void OnTriggerEnter2D(Collider2D player)
    {
        win_page.SetActive(true);
    }


}
