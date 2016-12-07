using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    public Text timeText;
    public static float myTimer = 90;
    public LevelManager levelManager;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        myTimer -= Time.deltaTime;
        timeText.text = "Time left: " + myTimer.ToString("f0"); 
        if(myTimer <= 0)
        {
            Debug.Log("Game Over!! Out of Time");
        }
	}
}
