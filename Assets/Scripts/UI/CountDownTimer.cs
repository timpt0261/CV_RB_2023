using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDownTimer : MonoBehaviour
{
    public TMPro.TextMeshPro timerUI;
    public SongManager songManager;
    public AudioSource countdownSFX;
    float timeRemaining;
    bool timerIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = songManager.songDelayInSeconds + 1f;
        timerIsRunning = true;
        timerUI.text = Mathf.FloorToInt(timeRemaining % 60).ToString();
        countdownSFX.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning) 
        {
            if (timeRemaining >= 0)
            {
                timeRemaining -= Time.deltaTime;
                if (timeRemaining < 1) { timerUI.text = "GO!"; return; }
                timerUI.text = Mathf.FloorToInt(timeRemaining % 60).ToString();
            }
            else
            {
                timerUI.text = "";
                timeRemaining = 0;
                timerIsRunning = false;
            }

        }
        
        

    }
}
