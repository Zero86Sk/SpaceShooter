using UnityEngine;
using System.Collections;

public class TargetNearestEnemy : MonoBehaviour {

    float nearestDistance = Mathf.Infinity;
    private GameObject nearestEnemy = null;

	// Use this for initialization
	void Start ()
    {
        StartTrackingEnemy();
    }
	
	// Update is called once per frame
	void Update ()
    {
        IsTrackingEnemy();
    }

    void StartTrackingEnemy ()
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

    void IsTrackingEnemy ()
    {
        if (nearestEnemy != null)
        {
            transform.rotation = Quaternion.LookRotation(nearestEnemy.transform.position - transform.position, Vector3.back);
        }
    }
}
