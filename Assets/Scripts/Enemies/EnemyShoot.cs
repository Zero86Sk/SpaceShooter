﻿using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {

    //Var for Player Shooting Bullet
    public GameObject bullet;
    public float shotDelay = 0.2f;
    //private bool readyToFire = true;

    // Use this for initialization
    void Start ()
    {
        Invoke("Shoot", shotDelay);
	}

    void Shoot ()
    {
        Instantiate(bullet, transform.position, transform.rotation);
        Invoke("Shoot", shotDelay);
    }
}
