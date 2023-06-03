using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camBob : MonoBehaviour
{
    public bool walking;
    public Animator cameraAnim;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D)) 
        {
            walking = true;
            cameraAnim.ResetTrigger("idle");
            cameraAnim.ResetTrigger("sprint");
            cameraAnim.SetTrigger("walk");
            if (walking == true)
            {
                if (Input.GetKeyDown(KeyCode.LeftShift))
                {
                    cameraAnim.ResetTrigger("idle");
                    cameraAnim.ResetTrigger("walk");
                    cameraAnim.SetTrigger("sprint");
                }
            }
        }
        else
        {
            cameraAnim.ResetTrigger("sprint");
            cameraAnim.ResetTrigger("walk");
            cameraAnim.SetTrigger("idle");
            walking = false;
        }
    }
}
