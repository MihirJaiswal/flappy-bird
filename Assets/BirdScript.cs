using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    public float flapStrength;

    public LogicScript Logic;

    public bool birdIsAlive = true;

    // Start is called before the first frame update
    void Start()
    {
       Logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Logic.gameOver();
        birdIsAlive = false;
    }
}
