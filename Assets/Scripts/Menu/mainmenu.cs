﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.IO;

public class MainMenu : MonoBehaviour {

    public string startLevel;
    public string loadLevel;
    public string settings;

    public Button loadGameButton;

    //public GameObject defaultButton;

    // Use this for initialization
    void Start()
    {
        if (File.Exists(Application.persistentDataPath + "/SaveGame.sav") == true)
        {
        loadGameButton.interactable = true;
        }
        else if (File.Exists(Application.persistentDataPath + "/SaveGame.sav") == false)
        {
            loadGameButton.interactable = false;
        }

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

    public void NewGame()
    {
        SceneManager.LoadScene(startLevel);
        Debug.Log("Start Game");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(loadLevel);
        Debug.Log("Load Game");

        GameManager.gmngr.LoadGame();
    }

    public void Settings()
    {
        SceneManager.LoadScene(settings);
        Debug.Log("Settings");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}