using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerStats : CharacterStats
{
    public float RunSpeed = 2f;
    public float Strength = 0;
    public bool isFacingRight = false;

    float horizontalInput = 0f;
    float verticalInput = 0f;

    // Start is called before the first frame update
    void Start(){
        EquipmentManager.instance.onEquipmentChanged += OnEquipmentChanged;
    }

    
    void OnEquipmentChanged(Equipment newItem, Equipment oldItem) {

        if (newItem != null) {
            dex.AddModifier(newItem.dexmodifier);
            str.AddModifier(newItem.strmodifier);
        }

        if (oldItem != null) {
            dex.RemoveModifier(oldItem.dexmodifier);
            str.RemoveModifier(oldItem.strmodifier);
        }
    }


    // Update is called once per frame
    void Update()
    {
        //disable movement when a UI button is clicked
        /*if (EventSystem.current.IsPointerOverGameObject())
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

        if (horizontalInput > 0)
        {
            transform.Translate(horizontal * (IncreaseSpeed(RunSpeed)) * Time.deltaTime * -1f);
        }
        else
        {
            transform.Translate(horizontal * (IncreaseSpeed(RunSpeed)) * Time.deltaTime);
        }

        transform.Translate(vertical * (IncreaseSpeed(RunSpeed)) * Time.deltaTime);
        //GetComponent<Rigidbody2D>().MovePosition(transform.position + position * RunSpeed * Time.deltaTime);
        //UnityEngine.Debug.Log(verticalInput);
        UnityEngine.Debug.Log("PlayerStats " + IncreaseSpeed(RunSpeed) + ", " + IncreaseStrength(Strength));
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
