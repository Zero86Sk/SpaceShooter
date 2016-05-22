using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour {

    public string startLevel;
    public string loadLevel;
    public string settings;

    //public GameObject defaultButton;

    // Use this for initialization
    void Start() {
        /*
                if (defaultButton != null)
                {
                    EventSystem.current.SetSelectedGameObject(defaultButton, null);
                }
        */
    }

    // Update is called once per frame
    void Update() {

    }

    public void StartGame() {
        SceneManager.LoadScene(startLevel);
        Debug.Log("Start Game");
    }

    public void LoadGame() {
        SceneManager.LoadScene(loadLevel);
        Debug.Log("Load Game");
    }

    public void Settings() {
        SceneManager.LoadScene(settings);
        Debug.Log("Settings");
    }

    public void Exit() {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}