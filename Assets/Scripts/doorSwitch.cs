using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorSwitch : MonoBehaviour
{
    public Animator switchAnim;
    public GameObject inttext, trap;
    public bool interactable, toggle;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            if (toggle == false)
            {
                inttext.SetActive(true);
                interactable = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }

    private void Update()
    {
        if (interactable == true)
        {
            if(Input.GetKeyDown(KeyCode.E)) 
            {
                switchAnim.SetTrigger("pull");
                trap.SetActive(false);
                inttext.SetActive(false);
                toggle = true;
                interactable = false;
            }
        }
    }
}
