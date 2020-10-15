using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float RunSpeed = 3f;
    public bool isFacingRight = false;

    float horizontalInput = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();

        flipSprite();

    }

    void move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        //Movement
        Vector3 horizontal = new Vector3(horizontalInput, 0.0f, 0.0f);
        Vector3 vertical = new Vector3(0.0f, Input.GetAxis("Vertical"), 0.0f);
        UnityEngine.Debug.Log(horizontal);
        //UnityEngine.Debug.Log(transform.position);
        transform.position = transform.position + horizontal * RunSpeed * Time.deltaTime;
        transform.position = transform.position + vertical * RunSpeed * Time.deltaTime;
    }

    void flipSprite()
    {
        //flip the sprite
        if ((horizontalInput < 0 && isFacingRight) || (horizontalInput > 0 && !isFacingRight))
        {
            isFacingRight = !isFacingRight;
            transform.Rotate(new Vector3(0, 180, 0));
        }
    }
}
