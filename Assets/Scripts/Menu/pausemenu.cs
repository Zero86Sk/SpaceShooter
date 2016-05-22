using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour {

    public string mainMenu;
    public string restartLevel;

    public GameObject pauseMenuCanvas;
    public GameObject mobileMenuCanvas;
    public bool isPaused;

    //public GameObject defaultButton;


    public void Start() {
        /*
                if (defaultButton != null)
                {
                    EventSystem.current.SetSelectedGameObject(defaultButton, null);
                }
        */
    }

    public void Update() {
        if (isPaused)
        {
            Time.timeScale = 0.0f;
            pauseMenuCanvas.SetActive(true);
        }
        else if (!isPaused)
        {
            Time.timeScale = 1.0f;
            pauseMenuCanvas.SetActive(false);
        }

#if  UNITY_STANDALONE

        if (Input.GetButtonDown("Start")) {
            PauseMenu();
        }
#endif

#if UNITY_ANDROID || UNITY_IOS || UNITY_IPHONE || UNITY_WP8 || UNITY_WP8_1 || UNITY_WINRT || UNITY_WINRT_8_0 || UNITY_WINRT_8_1

		if(isPaused)
		{
			mobileMenuCanvas.SetActive(false);
		} else if(!isPaused)
		{
			mobileMenuCanvas.SetActive(true);
		}

#endif

    }

    public void PauseMenu() {
        isPaused = !isPaused;
        //Debug.Log("Paused");
    }

    public void Continue() {
        isPaused = false;
    }

    public void Restart() {
        SceneManager.LoadScene(restartLevel);
    }

    public void MainMenu() {
        SceneManager.LoadScene(mainMenu);
    }

    public void Exit() {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}