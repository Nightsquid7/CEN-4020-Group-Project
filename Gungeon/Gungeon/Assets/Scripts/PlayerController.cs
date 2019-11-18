﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Vector2 movement;

    private int count;
    Rigidbody2D playerRB;
    public Animator animator;
    public Vector2 mousePos;
    public GameObject crosshair;

    public bool isAiming;

    public Camera cam;

    

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        count = 0;
        
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        
        isAiming = Input.GetButton("Fire1");

        Aim();
        
    }

    private void FixedUpdate()
    {

        playerRB.MovePosition(playerRB.position + movement * speed * Time.fixedDeltaTime);     
                
        // ensure that player is facing mouse aim
        if (playerRB.transform.position.x > mousePos.x)
        {
            playerRB.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            playerRB.transform.rotation = Quaternion.Euler(0, 0, 0);
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PickUp"))
        {
            collision.gameObject.SetActive(false);
            count++;            
        }
    }

    void Aim()
    {
        if (movement != Vector2.zero)
        {
            crosshair.transform.localPosition = mousePos;
        }
    }
    
}
