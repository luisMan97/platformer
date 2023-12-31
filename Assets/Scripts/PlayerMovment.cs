﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    public Rigidbody2D playerRb;
    public float speed = .5f;
    [SerializeField] private float jumpSpeed = 300;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerRb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, playerRb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            playerRb.AddForce(Vector2.up * jumpSpeed);
        }
    }
}
