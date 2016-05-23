using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public bool gameOverOnDestroy = false;
    public string gameOverMenu;

    // Use this for initialization
    void Start ()
    {
	
	}

    // Update is called once per frame
    void Update()
    {
        if (gameOverOnDestroy == true)
        {
            SceneManager.LoadScene(gameOverMenu);
        }
    }

    void OnDestroy()
    {
        gameOverOnDestroy = true;
        //Debug.Log("Gameover Screen");
    }
}
