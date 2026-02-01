using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBirdScript : MonoBehaviour
{
    public Rigidbody2D mrg;
    public float flapstrength;
    public LogicScript logic;
    public bool birdisalive = true;
    public AudioSource birdfly;

    void Start()
    {
        birdfly = GetComponent<AudioSource>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdisalive)
        {
            mrg.linearVelocity = Vector2.up * 6;
            birdfly.Play();
        }
        if (transform.position.y > 10 || transform.position.y < -8)
        {
            logic.G_over.Play();
            logic.gameover();
            birdisalive = false;
        }
    }
  
    public void OnCollisionEnter2D(Collision2D collision)
    {

        logic.G_over.Play();
        logic.gameover();
        birdisalive = false;

    }
}
