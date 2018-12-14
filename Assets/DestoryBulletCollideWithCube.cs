﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBulletCollideWithCube : MonoBehaviour
{



    void OnTriggerEnter2D(Collider2D other)

    {


        if (other.gameObject.tag == "CubeDestroysBullet")

        {

            Destroy(gameObject);

        }

    }
}