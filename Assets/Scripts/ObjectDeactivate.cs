using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDeactivate : MonoBehaviour 
{
    public GameObject pixel;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pixel.SetActive(false);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pixel.SetActive(true);
        }
    }

}
