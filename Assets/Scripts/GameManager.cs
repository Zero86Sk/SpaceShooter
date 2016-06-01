using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class GameManager : MonoBehaviour {

    // Main Menu var
    public string mainMenu;
    public string gameOverMenu;

    // Game Over var
    private bool gameOver = false;
    public float deathTimer = 1.0f;

    // Score var
    public float score;
    public Text scoreText;

    // High Score var
    private static float highScore;
    public Text highScoreText;

    // Previous Score var
    private static float lastScore;
    public Text lastScoreText;

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

    /*
    void Awake ()
    {
        if (gmngrInt == null)
        {
            DontDestroyOnLoad(gameObject);
            gmngrInt = this;
        }
        else if (gmngrInt != this)
        {
            Destroy(gameObject);
        }
    }
    */

    // Use this for initialization
    void OnEnable ()
    {

    }

    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        if (SceneManager.GetActiveScene().name != mainMenu || SceneManager.GetActiveScene().name != gameOverMenu)
        {
            if (GameObject.FindGameObjectWithTag("Player") == null)
            {
                gameOver = true;
            }

            if (!gameOver)
            {
                if (score > highScore)
                {
                    highScore = score;
                }
            }
            else GameOver();
        }
    }

    void OnGUI()
    {
        int currentScore = (int)(score);
        scoreText.text = currentScore.ToString();

        int currentHighScore = (int)(highScore);
        highScoreText.text = currentHighScore.ToString();
    }

    void GameOver ()
    {
        deathTimer -= Time.deltaTime;
        //Debug.Log("Time Till Death: " + deathTimer * Time.deltaTime);

        if (deathTimer <= 0)
        {
            SceneManager.LoadScene(gameOverMenu);
        }
        lastScore = score;
        SaveGame();
    }

    public void SaveGame ()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream saveFile = File.Create(Application.persistentDataPath + "/SaveGame.sav");

        SaveData data = new SaveData();
        data.highScore = highScore;
        data.lastScore = lastScore;

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

            highScore = data.highScore;
            lastScore = data.lastScore;
        }
    }
}
