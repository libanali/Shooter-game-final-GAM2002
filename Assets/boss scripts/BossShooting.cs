﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShooting : MonoBehaviour {



    public Transform TargetPlayer;

    public float playerRange;

    public GameObject EnemyBullet;

    public Transform launchpoint;

    public Transform launchpoint2;

    public float GapInBetweenShotsForEnemyBullet;


    private float Shotcounter;
    


    public AudioSource EnemyLaser;


    // Use this for initialization
    void Start()
    {



        TargetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        Shotcounter = GapInBetweenShotsForEnemyBullet;




    }

    // Update is called once per frame
    void Update()
    {

        Shotcounter -= Time.deltaTime;

        if (transform.localScale.x < 0 && TargetPlayer.transform.position.x > transform.position.x && TargetPlayer.transform.position.x < transform.position.x + playerRange && Shotcounter < 0)
        {

            Instantiate(EnemyBullet, launchpoint.position, launchpoint.rotation);
            Instantiate(EnemyBullet, launchpoint2.position, launchpoint2.rotation);
            Shotcounter = GapInBetweenShotsForEnemyBullet;
            EnemyLaser.Play();



        }

        if (transform.localScale.x > 0 && TargetPlayer.transform.position.x < transform.position.x && TargetPlayer.transform.position.x > transform.position.x - playerRange && Shotcounter < 0)

        {
            Instantiate(EnemyBullet, launchpoint.position, launchpoint.rotation);
            Instantiate(EnemyBullet, launchpoint2.position, launchpoint2.rotation);
            Shotcounter = GapInBetweenShotsForEnemyBullet;
            EnemyLaser.Play();       

        }



    }
}
