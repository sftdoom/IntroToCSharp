using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelTimer : MonoBehaviour
{
    //seconds
    public int timeLimit = 120;
    public Text timerText;
    private float timeElapsed = 0.0f;

    private void Update()
    {
       
        timeElapsed += Time.deltaTime;

        int timeRemaining=timeLimit - (int)timeElapsed;
        
        if (timeRemaining < 0)
        {
            timeRemaining = 0;

            SceneManager.LoadScene(0);
        }
        int minutesLeft=timeRemaining/60;
        int secondsLeft = timeRemaining % 60;

        
        timerText.text=minutesLeft.ToString("00")+ ":" + secondsLeft.ToString("00");




    }
}
