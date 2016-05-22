using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

    public GameObject bullet;

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
