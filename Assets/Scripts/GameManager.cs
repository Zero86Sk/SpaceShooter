using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GameManager : MonoBehaviour {

    //        if (SceneManager.GetActiveScene().name != mainMenu || SceneManager.GetActiveScene().name != gameOverMenu)

    // Main Menu var
    //public string mainMenu;
    public string gameOverMenu;

    // Game Over var
    private bool gameOver = false;
    public float deathTimer = 1.0f;

    // Score var
    private float score;
    public Text scoreText;

    // High Score var
    private static float highScore;
    public Text highScoreText;

    // Internal var
    public static GameManager gmngr;

    /*
    //private static GameManager gmngrInt;
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
    */

    void OnEnable ()
    {
        LoadGame ();
    }

    /*
    void Awake ()
    {
        if (gmngr == null)
        {
            DontDestroyOnLoad(gameObject);
            gmngr = this;
        }
        else if (gmngr != this)
        {
            Destroy(gameObject);
        }
    }
    */

    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            gameOver = true;
        }
        if (!gameOver)
        {
            if (score >= highScore)
            {
                highScore = score;
            }
        }
        else GameOver();
    }

    void GUI ()
    {
        //int sc = (int)(score);
        scoreText.text = score.ToString();

        //int hs = (int)(highScore);
        highScoreText.text = highScore.ToString();
    }

    void GameOver ()
    {
        deathTimer -= Time.deltaTime;
        //Debug.Log("Time Till Death: " + deathTimer * Time.deltaTime);

        if (deathTimer <= 0)
        {
            SceneManager.LoadScene(gameOverMenu);
        }

        score = highScore;
        SaveGame();
    }

    public void SaveGame ()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream saveFile = File.Create(Application.persistentDataPath + "/SaveGame.sav");

        SaveData data = new SaveData();

        //Data to Save
        data.highScore = highScore;

        bf.Serialize(saveFile, data);
        saveFile.Close();
    }

    public void LoadGame ()
    {
        if (File.Exists(Application.persistentDataPath + "/SaveGame.sav"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream saveFile = File.Open(Application.persistentDataPath + "/SaveGame.sav", FileMode.Open);

            SaveData data = (SaveData)bf.Deserialize(saveFile);
            saveFile.Close();

            //Data to Load
            highScore = data.highScore;
        }
    }
}
