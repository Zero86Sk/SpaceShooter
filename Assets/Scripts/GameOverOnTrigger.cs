using UnityEngine;
using System.Collections;

public class GameOverOnTrigger : MonoBehaviour {

    void OnDestroy ()
    {
        GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

        gameManager.gameOverOnDestroy = true;
        //Debug.Log("You Should Be Dead! and Brought to the Gameover Screen");
    }
}
