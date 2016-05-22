using UnityEngine;
using System.Collections;

public class ExplosionOnTrigger : MonoBehaviour {

    public GameObject boom;

	// Update is called once per frame
	void OnTriggerEnter ()
    {
	if (boom != null)
        {
            Instantiate(boom, transform.position, boom.transform.rotation);
        }
        Destroy(gameObject);
	}
}
