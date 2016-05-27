using UnityEngine;
using System.Collections;

public class RandomLinearMovement : MonoBehaviour {

    public float maxDistance = 1.0f;
    public float moveTime = 1.0f;

	// Use this for initialization
	void Start ()
    {
        StartCoroutine ("RandomMove");
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    IEnumerator RandomMove()
    {
        float t = 0.0f;

        Vector3 initialPosition = transform.position; // Where we are coming from
        Vector3 moveVector = Random.insideUnitCircle * maxDistance;
        Vector3 endPosition = initialPosition + moveVector; // Where We are going to

        while (t < moveTime)
        {
            // Lerp = From Point A to B takes a certain amount of time to get there
            transform.position = Vector3.Lerp(initialPosition, endPosition, t / moveTime);

            t += Time.deltaTime; // time now counts upwards
            yield return null; // Come Back after this frame is done
        }
        StartCoroutine("RandomMove"); 
    }
}
