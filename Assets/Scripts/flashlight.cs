using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour
{
    public GameObject lights;
    public bool toggle;
    public AudioSource toggleSound;

    void Start()
    {
        if (toggle == false)
        {
            lights.SetActive(false);
        }
        if(toggle == true)
        {
            lights.SetActive(true);
        }
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            toggle = !toggle;
            //toggleSound.Play();
            if (toggle == false)
            {
                lights.SetActive(false);
            }
            if (toggle == true)
            {
                lights.SetActive(true);
            }
        }
    }
}
