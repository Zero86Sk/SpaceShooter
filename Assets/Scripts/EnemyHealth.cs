using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    private GameObject enemyShip;

    public int initialHealth = 100;
    private int currentHealth;

    // Particle var
    public GameObject particleOnHit;
    public GameObject particleOnDeath;

    // Score var
    public float enemyScore = 10.0f;

    // Use this for initialization
    void Start ()
    {
        currentHealth = initialHealth;
	}

    void OnTriggerEnter (Collider col)
    {
        currentHealth -= 1; // you can also do currentHealth --; (decerment)

        if (particleOnHit != null)
        {
            Instantiate(particleOnHit, col.transform.position, particleOnHit.transform.rotation);
            //Instantiate(particleOnHit, col.transform.position, Quaternion.identity);
        }

        if (currentHealth <= 0)
        {
            if (particleOnDeath != null)
            {
                Instantiate(particleOnDeath, transform.position, particleOnDeath.transform.rotation);
            }

            GameManager.gmngr.score += enemyScore; // Adds points to score when Enemy dies (van edit value in editor)
            Destroy(gameObject);
        }
    }
}
