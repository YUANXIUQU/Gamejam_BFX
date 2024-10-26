using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wood_generate : MonoBehaviour
{
    public Transform[] spawnpoint;
    public int i;
    public GameObject wood;
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Wood.createnext)
        {
            i++;
            if(i<spawnpoint.Length)
            {
                Instantiate(wood, spawnpoint[i].position, Quaternion.identity);
            }
            Wood.createnext = false;
        }
    }
}
