using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddle : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject ball;
    public float speed = 4f;

    void Start()
    {
        rb= GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float ballPos = ball.transform.position.y;
        float paddlePos = rb.position.y;
        float direction = Mathf.Sign(ballPos - paddlePos);
        rb.linearVelocity = new Vector2(0, direction * speed);

    }
}
