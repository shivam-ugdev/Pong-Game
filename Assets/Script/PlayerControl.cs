using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 13f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       float moveInput = Input.GetAxis("Vertical");

       rb.linearVelocity = new Vector2(0, moveInput* moveSpeed);
    }

}
