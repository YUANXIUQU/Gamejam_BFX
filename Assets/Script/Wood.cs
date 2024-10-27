using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wood : MonoBehaviour
{
    public float speed;
    public bool stopmove;
    public static bool createnext;

    public GameObject rock1;
    public GameObject rock2;
    public AudioSource wood_settled;
    public ParticleSystem effect;

    int num_stopmove;
    int num_effect;


    // Update is called once per frame
    void Start()
    {
        createnext = false;
        num_stopmove = 0;
        stopmove = false;
        rock1.SetActive(false);
        rock2.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            stopmove = true;
            createnext = true;
            rock1.SetActive(true);
            rock2.SetActive(true);
            wood_settled.Play();
            num_stopmove++;
        }

        if(stopmove == false)
        {
            transform.Translate(Vector3.down * speed * speed * Time.deltaTime);
        }
        if(num_stopmove == 1)
        {
            playeffect();
        }

  
    }

    void playeffect()
    {
        if(num_effect == 0)
        {
            effect.Play();
        }
        num_effect++;
    }
}
