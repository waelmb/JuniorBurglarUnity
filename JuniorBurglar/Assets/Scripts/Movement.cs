using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.EventSystems;

public class Movement : PlayerStats
{
    
    public float RunSpeed = 3f ;
    public bool isFacingRight = false;

    float horizontalInput = 0f;
    float verticalInput = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //disable movement when a UI button is clicked
        /*if(EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }*/

        move();

        flipSprite();

    }

    void move()
    {
        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Movement
        Vector3 horizontal = new Vector3(horizontalInput, 0.0f, 0.0f);
        Vector3 vertical = new Vector3(0.0f, verticalInput, 0.0f);
        //UnityEngine.Debug.Log(horizontal);
        //UnityEngine.Debug.Log(transform.position);
        //transform.position = transform.position + horizontal * RunSpeed * Time.deltaTime;
        //transform.position = transform.position + vertical * RunSpeed * Time.deltaTime;

        if(horizontalInput > 0)
        {
            transform.Translate(horizontal * (RunSpeed + IncreaseSpeed()) * Time.deltaTime * -1f);
        }
        else
        {
            transform.Translate(horizontal * (RunSpeed + IncreaseSpeed()) * Time.deltaTime);
        }
        
        transform.Translate(vertical * (RunSpeed + IncreaseSpeed()) * Time.deltaTime);
        //GetComponent<Rigidbody2D>().MovePosition(transform.position + position * RunSpeed * Time.deltaTime);

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
