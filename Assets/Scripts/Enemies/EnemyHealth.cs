﻿using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    //private GameObject enemyShip;
    public GameObject objectToDestroy;

    public int initialHealth = 100;
    public int currentHealth;

    // Particle var
    public GameObject particleOnHit;
    public GameObject particleOnDeath;

    // Use this for initialization
    void Start ()
    {
        currentHealth = initialHealth;

        if (objectToDestroy == null)
        {
            objectToDestroy = gameObject;
        }
    }

    void update ()
    {

    }

    void OnTriggerEnter (Collider col)
    {
        currentHealth -= 1; // you can also do currentHealth --; (decerment)

        if (particleOnHit != null)
        {
            Instantiate(particleOnHit, col.transform.position, particleOnHit.transform.rotation);
            //Instantiate(particleOnHit, col.transform.position, Quaternion.identity);
        }

        if (currentHealth <= 0)
        {
            if (particleOnDeath != null)
            {
                Instantiate(particleOnDeath, transform.position, particleOnDeath.transform.rotation);
            }
            Destroy(objectToDestroy);
        }
    }
}
