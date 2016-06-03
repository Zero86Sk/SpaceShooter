using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {

    public string mainMenu;
    public string restartLevel;

    //public GameObject defaultButton;

    // Use this for initialization
    void Start()
    {
        /*
                if (defaultButton != null)
                {
                    EventSystem.current.SetSelectedGameObject(defaultButton, null);
                }
        */
    }

    // Update is called once per frame
    void Update()
    {

    }

    // MENU OPTIONS

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void Restart()
    {
        SceneManager.LoadScene(restartLevel);

        //Loads Game
        GameManager.gmngr.LoadGame();
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}