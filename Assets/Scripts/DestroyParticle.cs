using UnityEngine;
using System.Collections;

public class DestroyParticle : MonoBehaviour {
	
	// Update is called once per frame
	void Update ()
    {
        DestroyParticleSys();
    }

    void DestroyParticleSys()
    {
        ParticleSystem particleSys = GetComponent<ParticleSystem>();

        if (!particleSys.isPlaying)
        {
            Destroy(gameObject);
        }
    }
}
