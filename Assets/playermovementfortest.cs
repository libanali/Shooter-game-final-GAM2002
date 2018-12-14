﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovementfortest : MonoBehaviour {



    public float speed;

    Rigidbody2D rb;

    public float TakeAwayFuel = 0.4f;

    public Transform RespawnPoint;


    private Vector2 dist;







    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }



    void FixedUpdate()
    {



        float move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * move, rb.velocity.y);



        if (move != 0)
        {


            //GetComponent<Fuel>().currentFuel -= TakeAwayFuel;

            GetComponent<Fuel>().TakeSomeFuel(TakeAwayFuel);
            /*    
                if (GetComponent<Fuel>().currentFuel <= 0)
                { 

                  ByeBye();

                } 
              */
        }
    }




    void ByeBye()
    {


        transform.position = RespawnPoint.transform.position;
        GetComponent<Fuel>().currentFuel = 250;
    }
}
