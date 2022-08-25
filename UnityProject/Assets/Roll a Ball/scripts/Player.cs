using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    

   
    public Text scoreText;
    public float jumpStrength = 7.0f;
    
    private bool touchingGround;
    public Transform targetObject;
    

    public int points = 0;
    public float boostpower = 5;

    public float boostCooldown = 5.0f;
    private float boostTimer = 0;


    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float forward = Input.GetAxisRaw("Vertical");

        rb.AddForce(horizontal, 0.0f, forward);

        boostTimer -= Time.deltaTime;



        if(boostTimer<=0&&Input.GetButtonDown("Boost"))
        {
            rb.AddForce(horizontal*boostpower,
                0.0f, 
                forward*boostpower, 
                ForceMode.Impulse);

            boostTimer = boostCooldown;

        }
        
        if (Input.GetButtonDown("Jump"))
        {
            Rigidbody playerRb = GetComponent<Rigidbody>();
            playerRb.AddForce(0, jumpStrength, 0, ForceMode.Impulse);

        }

        scoreText.text = points.ToString();
        


    }
}
