﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic_movement : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb2d;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float getJump = Input.GetAxis("Jump");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb2d.AddForce(movement*speed);
        Vector2 jump = new Vector2(0, getJump * 10);
        rb2d.AddForce(jump * speed);
    }
}
