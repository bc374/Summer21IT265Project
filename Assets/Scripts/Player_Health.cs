using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set; }
    private Animator anim;
    private bool dead;


    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();

    }

    public void HitDamage (float _damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0)
        {
            anim.SetTrigger("Injured");
        }
        else

        {
            if (!dead)
            {
                anim.SetTrigger("Death");
                GetComponent<Player_Movement>().enabled = false;
                dead = true;
                {
                    SceneManager.LoadScene("Game_Over");
                }
            }
        }
    }

    public void CollectHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
}  