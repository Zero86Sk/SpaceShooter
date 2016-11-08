using UnityEngine;
using System.Collections;

public class ParticleOnTrigger : MonoBehaviour {

    public GameObject objectToDestroy;
    public GameObject particle;

    void Start ()
    {
        if (objectToDestroy == null)
        {
            objectToDestroy = gameObject;
        }
    }

    void Update ()
    {

    }

	// Update is called once per frame
	void OnTriggerEnter ()
    {
    	if (particle != null)
        {
            Instantiate(particle, transform.position, particle.transform.rotation);
        }
        Destroy(objectToDestroy);
	}
}
