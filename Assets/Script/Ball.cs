using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speedBall = 7f;
    float speedInc = 1.1f;
    public float maxSpeed = 15f;

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();

        ResetPosition();
    }

   
    public void LaunchBall()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rb.linearVelocity = new Vector2 (x, y).normalized *speedBall ;
    }
     void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Vector2 currentVelocity = rb.linearVelocity;
            float newSpeed = currentVelocity.magnitude*speedInc;

            if(newSpeed > maxSpeed)
            {
                newSpeed = maxSpeed;
            }
            rb.linearVelocity = currentVelocity.normalized*newSpeed;
        }
    }

    public void ResetPosition()
    {
        rb.linearVelocity = Vector2.zero;
        rb.position = Vector2.zero;
        Invoke("LaunchBall", 1f);

    }
}
