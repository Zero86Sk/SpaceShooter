using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

    //Var for Player Shooting Bullet
    public GameObject bullet;
    public float shotDelay = 0.2f;
    private bool readyToFire = true;

    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	if (Input.GetButton("Fire1") && readyToFire)
        {
            Shoot ();
            readyToFire = false;
            Invoke("ResetReadyToFire", shotDelay);
        }
	}

    void Shoot ()
    {
        Instantiate(bullet, transform.position, transform.rotation);
    }

    void ResetReadyToFire ()
    {
        readyToFire = true;
    }
}
