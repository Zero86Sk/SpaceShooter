using UnityEngine;
using System.Collections;

public class SeekingMissile : MonoBehaviour {

    // Var for Missiles
    public float initVelocity = 10.0f;
    public float missleAccelerationForce = 10.0f;
    public float maxVelocity = 10.0f;

    private float maxSqrVelocity;

    // Var for Tracking Enemies
    float nearestDistance = Mathf.Infinity;
    GameObject nearestEnemy = null;

    // Use this for initialization
    void Start ()
    {
        StartTrackingEnemy();

        maxSqrVelocity = maxVelocity * maxVelocity;

        Rigidbody missle = GetComponent<Rigidbody>();
        missle.AddForce(transform.forward * initVelocity, ForceMode.VelocityChange);
    }
    
    // Updates at every Frame
    void Update()
    {
        IsTrackingEnemy();
    }

    // Physics Update
    void FixedUpdate ()
    {
        Rigidbody missle = GetComponent<Rigidbody>();
        missle.AddForce(transform.forward * missleAccelerationForce * Time.deltaTime, ForceMode.Acceleration);

      //if (missle.velocity.magnitude > maxVelocity)
        if (missle.velocity.sqrMagnitude > maxSqrVelocity)
        {
           //Debug.Log("Missle Velocity Is: " + missle.velocity.magnitude);

           missle.velocity = missle.velocity.normalized * maxVelocity;

           //Debug.Log("Missle Velocity Should Be: " + (missle.velocity.normalized * maxVelocity).magnitude);
        }
    }

    void StartTrackingEnemy()
    {
        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Enemies"))
        {
            float distance = (transform.position - obj.transform.position).sqrMagnitude;
            if (distance < nearestDistance)
            {
                nearestDistance = distance;
                nearestEnemy = obj;
            }
        }
    }

    void IsTrackingEnemy()
    {
        if (nearestEnemy != null)
        {
            transform.rotation = Quaternion.LookRotation (nearestEnemy.transform.position - transform.position, Vector3.back);
        }
    }
}
