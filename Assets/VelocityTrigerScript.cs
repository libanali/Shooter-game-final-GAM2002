﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityTrigerScript : MonoBehaviour
{



    void OnCollisionEnter2D(Collision2D other)


    {


        if (other.gameObject.tag == "Player")
        {

            GetComponent<planevelocityforboss>();


        }


    }

}