using UnityEngine;
using System.Collections;

public class ForwardMovement : MonoBehaviour {

    public float speed = 25.0f;
	
	// Update is called once per frame
	void Update ()
    {
        MoveForward ();
	}

    void MoveForward ()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
