using UnityEngine;
using System.Collections;

public class ParticleOnTrigger : MonoBehaviour {

    public GameObject particle;

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
        Destroy(gameObject);
	}
}
