﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newplayermovementforDIMENSION2 : MonoBehaviour
{


    public float speed;

    Rigidbody2D rb;










    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }



    void FixedUpdate()
    {



        float move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * move, rb.velocity.y);


    }

}