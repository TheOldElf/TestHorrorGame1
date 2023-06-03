using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonEnemy : MonoBehaviour
{
    public GameObject zayac, enWall, disWall;
    public Collider collision;
    public bool blocks;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            zayac.SetActive(true);
            if (blocks == true)
            {
                enWall.SetActive(true);
                disWall.SetActive(false);
            }
            collision.enabled = false;
        }
    }
}
