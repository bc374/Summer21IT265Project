using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_Active : MonoBehaviour
{
    public GameObject box;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            box.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            box.SetActive(false);
        }
    }

}
