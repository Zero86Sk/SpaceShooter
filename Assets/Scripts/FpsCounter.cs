using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FpsCounter : MonoBehaviour
{

	int framecount = 0;
	float elapsedTime = 0.0f;
	int fps = 0;
	public float targetUpdateTime = 1.0f; //seconds

    //public GameObject fpsCanvas; 
    //public bool fpsCounterOn;

    public Text fpsText;

	// Use this for initialization
	void Start ()
    {
        //fpsText = GetComponent<GUIText>() as GUIText;
	}
	
	// Update is called once per frame
	void Update ()
    {
        FrameCounter();
    }

    void FrameCounter ()
    {
        framecount++;
        elapsedTime += Time.deltaTime;

        if (elapsedTime > targetUpdateTime)
        {
            fps = Mathf.FloorToInt(framecount / elapsedTime);
            framecount = 0;
            elapsedTime = targetUpdateTime - elapsedTime;

            fpsText.text = "FPS: " + fps;
        }
    }
}
