﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectOnceCollidesWithBullets : MonoBehaviour
{



    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Bullet")

            Destroy(gameObject);
    }
}
