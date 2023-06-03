using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomStartSwitch : MonoBehaviour
{
    public GameObject thing1, thing2, thing3, thing4;
    int randNum;

    private void Start()
    {
        randNum = Random.Range(0, 4);
        if (randNum == 0)
        {
            thing1.SetActive(true);
        }
        if (randNum == 1)
        {
            thing2.SetActive(true);
        }
        if (randNum == 2)
        {
            thing3.SetActive(true);
        }
        if (randNum == 3)
        {
            thing4.SetActive(true);
        }
    }
}
