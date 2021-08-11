using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Death : MonoBehaviour
{
    public GameObject EnemyDeath;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Projectile")
        {
            Instantiate(EnemyDeath, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
