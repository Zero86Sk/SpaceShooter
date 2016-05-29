using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    // Main Menu var
    public string mainMenu;
    public string gameOverMenu;

    // Game Over var
    //private bool gameOver = false;
    public float deathTimer = 1.0f;

    // Internal var
    private static GameManager gmngrInt;

    public static GameManager gmngr
    {
        get
        {
            if (gmngrInt != null)
            {
                return gmngrInt;
            }
            else
            {
                GameObject gameManager = new GameObject("GameManager");

                gmngrInt = gameManager.AddComponent<GameManager>();
                return gmngrInt;
            }
        }
    }

    // Use this for initialization
    void OnEnable ()
    {
        //LoadGame();
    }

    void Start ()
    {
        gmngrInt = this;
    }

    // Update is called once per frame
    void Update ()
    {
        if (Application.loadedLevelName != gameOverMenu ||
            Application.loadedLevelName != mainMenu)
        {
            if (GameObject.FindGameObjectWithTag("Player") == null)
            {
                GameOver();
            }
            else
            {
                //gameOver = false;
            }
        }
    }

    void GameOver ()
    {
        deathTimer -= Time.deltaTime;
        //Debug.Log("Time Till Death: " + deathTimer * Time.deltaTime);

        if (deathTimer <= 0)
        {
            SceneManager.LoadScene(gameOverMenu);
        }
    }

}
