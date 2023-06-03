using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomJumpscares : MonoBehaviour
{
    public GameObject img1, img2;
    public float randNum, waitTime;
    public bool looping;

    private void Start()
    {
        looping= true;
        StartCoroutine(randomScares());
    }
    IEnumerator randomScares()
    {
        yield return new WaitForSeconds(waitTime);
        randNum = Random.Range(0, 3);
        if (randNum == 0)
        {
            img1.SetActive(true);
        }
        if (randNum == 1)
        {
            img2.SetActive(true);
        }
        if (randNum == 2)
        {

        }
    }
}
