using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Switch : MonoBehaviour
{
    public GameObject character1, character2;
    private Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    int oneAvatarOn = 1;
    void Start()
    {
        character1.gameObject.SetActive(true);
        character2.gameObject.SetActive(false);
    }
    public void SwitchCharacter()
    {
        switch (oneAvatarOn)
        {
            case 1:

                oneAvatarOn = 2;

                character1.gameObject.SetActive(false);
                character2.gameObject.SetActive(true);
                break;

            case 2:

                oneAvatarOn = 1;

                character1.gameObject.SetActive(true);
                character2.gameObject.SetActive(false);
                break;

        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            {
                GetComponent<Character_Switch>().enabled = true;
            GetComponent<Points>().enabled = true; 
            }

    }
}
