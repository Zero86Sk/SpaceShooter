using UnityEngine;
using System.Collections;

public class MovementFollowPlayer : MonoBehaviour {

    public float maxDistance = 1.0f;
    public float moveTime = 1.0f;
    public float waitTime = 1.0f;

    private GameObject playerShip;

    // Use this for initialization
    void Start ()
    {
        playerShip = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine ("RandomMove");
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    IEnumerator RandomMove()
    {
        if (playerShip != null)
        {
            float t = 0.0f;
            float currentMoveTime = moveTime; // Fixes Buffer overflow while in editing

            Vector3 initialPosition = transform.position; // Where We are coming from
            Vector3 moveVector = Random.insideUnitCircle * maxDistance;
            Vector3 endPosition = playerShip.transform.position + moveVector; // Where We are going to

            if (currentMoveTime < 0.0f)
            {
                currentMoveTime = float.Epsilon; // Float.Epsilon is the lowest float in the universe
                Debug.LogWarning("Current Move Time is 0 or less !!!");
            }

            while (t < currentMoveTime)
            {
                // Lerp = From Point A to B takes a certain amount of time to get there
                transform.position = Vector3.Lerp(initialPosition, endPosition, t / currentMoveTime);

                t += Time.deltaTime; // time now counts upwards
                yield return null; // Come Back after this frame is done
            }
            yield return new WaitForSeconds(waitTime);
        }
        else
        {
            playerShip = GameObject.FindGameObjectWithTag("Player");
            yield return new WaitForSeconds(waitTime);
        }
        StartCoroutine("RandomMove"); 
    }
}
