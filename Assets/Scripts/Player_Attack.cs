using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private Transform laserPoint;
    [SerializeField] private GameObject[] lasers;

    private Animator anim;
    private Player_Movement playerMovement;
    private float cooldownTime = Mathf.Infinity;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<Player_Movement>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && cooldownTime > attackCooldown)
            Attack();

        cooldownTime += Time.deltaTime;
    }

    private void Attack()
    {
        anim.SetTrigger("Attack");
        cooldownTime = 0;

        lasers[FindLaser()].transform.position = laserPoint.position;
        lasers[FindLaser()].GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));
    }

    private int FindLaser()
    {
        for (int i = 0; i < lasers.Length; i++)
        {
            if (!lasers[i].activeInHierarchy)
                return i;
        }
        return 0;
    }
}
