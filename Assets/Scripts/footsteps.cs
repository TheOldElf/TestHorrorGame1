using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footsteps : MonoBehaviour
{
    public AudioSource footstepWalk, footstepSprint;
    public bool sprinting;

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                sprinting = true;
            }
            if (Input.GetKeyUp(KeyCode.LeftShift)) 
            {
                sprinting = false;
            }
            if (sprinting == true)
            {
                footstepWalk.enabled = false;
                footstepSprint.enabled = true;
            }
            if (sprinting == false)
            {
                footstepWalk.enabled = true;
                footstepSprint.enabled = false;
            }
        }
        else
        {
            footstepWalk.enabled = false;
            footstepSprint.enabled = false;
            sprinting = false;
        }
    }
}
