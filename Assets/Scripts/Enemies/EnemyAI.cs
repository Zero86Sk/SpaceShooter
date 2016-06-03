using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    public float fwdSpeed = 1.0f;
    public float sinAmpletude = 1.0f;
    public float sinFrequency = 1.0f;

    private float verticalOffset = 0.0f;
    private float time;

	// Use this for initialization
	void Start ()
    {
	
	}

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        // This needs to be there to negate the Vertical Offset
        // Removes offset from the enemy
        transform.position -= verticalOffset * transform.right;

        MoveForward();
        MoveVertical();
    }

    void MoveForward()
    {
        // Moves Enemy Forward
        transform.position += transform.forward * fwdSpeed * Time.deltaTime;
    }

    void MoveVertical()
    {
        // Create Vertical Offset
        verticalOffset = Mathf.Sin(time * sinFrequency * 2 * Mathf.PI) * sinAmpletude;

        // Ajusts Enemy Movement Vertically
        transform.position += verticalOffset * transform.right;
    }
}