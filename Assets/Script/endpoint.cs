using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endpoint : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 0;
    }
}
