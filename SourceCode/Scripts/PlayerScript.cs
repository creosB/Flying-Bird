using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // for speed
    public float JumpSpeed = 1.0f;
    public bool PlayerIsDead = false;
    // player rigidbody created
    public Rigidbody2D rb2D = null;
    // GameMode refference
    public GameManager GameManagerRef = null;
    public GameObject DeadthScreen = null;  


    private void Start()
    {
        Time.timeScale = 0.0f;
    }

    void Update()
    {
        // if player click the mouse, player will go up
        if (Input.GetMouseButtonDown(0))
        {
            rb2D.velocity = Vector2.up * JumpSpeed;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            GameManagerRef.UpdateScore();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathArea")
        {
            PlayerIsDead = true;
            Time.timeScale = 0.0f;
            DeadthScreen.SetActive(true);
        }
    }
}
