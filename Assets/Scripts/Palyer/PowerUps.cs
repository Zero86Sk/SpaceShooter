using UnityEngine;
using System.Collections;

public class PowerUps : MonoBehaviour {

    public GameObject particle;
    public GameObject playerShip;

    void OnTriggerEnter ()
    {
        //Didnt work
        //GameObject playerShip = GameObject.FindGameObjectWithTag("Player");

        if (particle != null)
        {
            Instantiate(particle, transform.position, particle.transform.rotation);
        }
        
        playerShip.SendMessage("PwrUp");
        Destroy(gameObject);
    }
}
