using UnityEngine;
using System.Collections;

public class BulletRotation2D : MonoBehaviour {

    // RELATIVE ROTATION !

	public float rotation = 45.0f;
    public float rotationTime = 1.0f;
    //public float rotationSpeed = 1.00f;
    
    // Use this for initialization
	void Start ()
    {
        StartCoroutine("RotateUp");
	}
	
    IEnumerator RotateUp ()
    {
        float t = 0.0f;

        //while t is greater than rotation time this corutine will loop
        while (t < rotationTime * 0.5f)
        {
            transform.RotateAround(transform.position, transform.up, Time.deltaTime / (rotationTime * 0.5f) * rotation);

            t += Time.deltaTime; // t is now a timer counting up
            yield return null; // Come Back after this frame is done
        }
        StartCoroutine("RotateDown");
    }

    IEnumerator RotateDown()
    {
        float t = 0.0f;

        //while t is greater than rotation time this corutine will loop
        while (t < rotationTime * 0.5f)
        {
            transform.RotateAround(transform.position, transform.up, -Time.deltaTime / (rotationTime * 0.5f) * rotation);

            t += Time.deltaTime; // t is now a timer counting up
            yield return null; // Come Back after this frame is done
        }
        StartCoroutine("RotateUp");
    }

}
