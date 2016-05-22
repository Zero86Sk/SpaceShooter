using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

    public GameObject bullet;
    public float shotDelay = 0.2f;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	if (Input.GetButton("Fire1"))
        {
            Bullet1 ();
        }
	}

    void Bullet1 ()
    {
        Instantiate(bullet, transform.position, bullet.transform.rotation);
    }
}
