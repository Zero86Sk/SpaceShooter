using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public string mainMenu;
    public string restartLevel;

    public Canvas pauseMenuCanvas;
    //public Canvas mobileMenuCanvas;

    public bool isMenuPaused = false;

    //public GameObject defaultButton;


    void Start ()
    {
        /*
	if (defaultButton != null)
	{
		EventSystem.current.SetSelectedGameObject(defaultButton, null);
	}
        */
    }

    void OnAwake ()
    {
        isMenuPaused = false;
    }

    void Update ()
    {
        if (isMenuPaused)
        {
            Time.timeScale = 0.0f;
            pauseMenuCanvas.enabled = true;
        }
        else if (!isMenuPaused)
        {
            Time.timeScale = 1.0f;
            pauseMenuCanvas.enabled = false;
        }

#if  UNITY_STANDALONE

        if (Input.GetButtonDown("Start"))
        {
            Paused();
        }

#endif
#if UNITY_ANDROID || UNITY_IOS || UNITY_WSA

	if(isPaused)
	{
		mobileMenuCanvas.SetActive(false);
	}
	else if(!isPaused)
	{
		mobileMenuCanvas.SetActive(true);
	}

#endif
    }

    public void Paused()
    {
        isMenuPaused = !isMenuPaused;
        //Debug.Log("Paused");

    }

    // MENU OPTIONS

    public void Resume()
    {
        isMenuPaused = false;
    }

    public void Restart()
    {
        SceneManager.LoadScene(restartLevel);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}