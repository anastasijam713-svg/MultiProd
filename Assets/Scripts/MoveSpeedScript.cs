/*using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MoveSpeedScript : MonoBehaviour
{
    public float Movespeed=5;
    public float deadzone = -40;
    public LogicScript logic;
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * Movespeed) * Time.deltaTime;

        if (logic.score % 5 == 0)
        {
            Movespeed += 2;
        }
        if (transform.position.x < deadzone)
        {
            Debug.Log("Pipe Destoyed");
            Destroy(gameObject);
        }

    }
}*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpeedScript : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float deadzone = -40f;
    public LogicScript logic;
    private int lastScore = 0; 

    void Update()
    {
  
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;


        if (transform.position.x < deadzone)
        {
            Debug.Log("Pipe Destroyed");
            Destroy(gameObject);
        }
    }
}

