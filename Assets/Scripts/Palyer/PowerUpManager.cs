using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerUpManager : MonoBehaviour {

    public static PowerUpManager pwrupm;

    public GameObject[] weapons;
    private int powerLevel = 0;
    public Text powerUpText;

    public void PwrUp()
    {
        powerLevel += 1;

        //Activate Single Shot
        if (powerLevel == 0)
        {
            weapons[0].SetActive(true);
            weapons[1].SetActive(false);
            weapons[2].SetActive(false);
            weapons[3].SetActive(false);
            weapons[4].SetActive(false);
        }

        //Activate Double Shot
        if (powerLevel == 1)
        {
            weapons[0].SetActive(false);
            weapons[1].SetActive(true);
            weapons[2].SetActive(false);
            weapons[3].SetActive(false);
            weapons[4].SetActive(false);
        }

        //Activate Tripple Shot
        if (powerLevel == 2)
        {
            weapons[0].SetActive(false);
            weapons[1].SetActive(false);
            weapons[2].SetActive(true);
            weapons[3].SetActive(false);
            weapons[4].SetActive(false);
        }

        //Activate Overkill Shot
        if (powerLevel == 3)
        {
            weapons[0].SetActive(false);
            weapons[1].SetActive(false);
            weapons[2].SetActive(true);
            weapons[3].SetActive(true);
            weapons[4].SetActive(true);
        }
    }

    void Update ()
    {
        if (powerLevel == 0)
        {
            powerUpText.text = "Single Shot";
        }

        if (powerLevel == 1)
        {
            powerUpText.text = "Tripple Laser";
        }

        if (powerLevel == 2)
        {
            powerUpText.text = "Beam";
        }

        if (powerLevel == 3)
        {
            powerUpText.text = "OVERKILL!!!";
        }
    }
}
