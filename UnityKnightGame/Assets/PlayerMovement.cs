using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jumpBool = false;
    bool crouchBool = false;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if(Input.GetButtonDown("Jump"))
        {
            jumpBool = true;
        }
        if(Input.GetButtonDown("Crouch"))
        {
            crouchBool = true;
        }
        else if(Input.GetButtonUp("Crouch"))
        {
            crouchBool = false;
        }
	}

    void FixedUpdate()
    {
        //Move character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouchBool, jumpBool);
        jumpBool = false;
 

        
    }
}
