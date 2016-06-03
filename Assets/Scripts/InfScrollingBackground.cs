using UnityEngine;
using System.Collections;

public class InfScrollingBackground : MonoBehaviour {

    // Scrolling
    public float scrollSpeed = 1.0f;
    public float scrollMultiplier = 1.0f;

    private GameObject playerShip;

    // Use this for initialization
    void Start ()
    {
        playerShip = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (playerShip != null)
        {
            horizontalScrolling ();
        }
        else
        {
            playerShip = GameObject.FindGameObjectWithTag("Player");
        }
	}


    void horizontalScrolling ()
    {
        Renderer bg = GetComponent<Renderer>();
        Vector2 newTextureOffset = bg.material.mainTextureOffset;

        //Horizontal Scroll
        newTextureOffset.x += scrollSpeed * Time.deltaTime;
        newTextureOffset.y = playerShip.transform.position.y * scrollMultiplier;

        bg.material.mainTextureOffset = newTextureOffset;
    }

    /*
    void verticalScrolling ()
    {
        Renderer bg = GetComponent<Renderer>();
        Vector2 newTextureOffset = bg.material.mainTextureOffset;

        //Vertical Scroll
        newTextureOffset.x = playerShip.transform.position.x * scollMultiplier;
        newTextureOffset.y += scrollSpeed * Time.deltaTime;

        bg.material.mainTextureOffset = newTextureOffset;
    }
    */
}
