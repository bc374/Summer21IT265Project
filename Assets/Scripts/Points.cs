using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
    public float points { get; private set; }
    public Text countText;

    private Rigidbody2D body;
    private int count;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        SetCountText();
    }

    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.gameObject.CompareTag("Points"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            ScoreKeeper.instance.AddPoints();

        }

    }
    void SetCountText()
    {
        countText.text = "" + count.ToString();

    }
}
