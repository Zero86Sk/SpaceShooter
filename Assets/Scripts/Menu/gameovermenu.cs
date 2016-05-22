using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class gameovermenu : MonoBehaviour {

    public string mainMenu;
    public string restartLevel;

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

    public void MainMenu() {
        SceneManager.LoadScene(mainMenu);
    }

    public void Restart() {
        SceneManager.LoadScene(restartLevel);
    }

    public void Exit() {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}