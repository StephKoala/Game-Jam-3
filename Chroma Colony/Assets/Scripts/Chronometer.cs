using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Chronometer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float timeLeftInSeconds;
    public int minTime, secTime;
    public bool gameOver;

    // Update is called once per frame
    void Update()
    {
        //Count time
        CountTime();
    }

    //Count time
    public void CountTime()
    {
        if (!gameOver)
        {
            //Set time
            timeLeftInSeconds += Time.deltaTime;
            minTime = Mathf.FloorToInt(timeLeftInSeconds / 60);
            secTime = Mathf.FloorToInt(timeLeftInSeconds % 60);

            //Show time
            timerText.text = string.Format("{00:00}:{01:00}", minTime, secTime);
        }
    }

    public void ResetChronometer()
    {
        timeLeftInSeconds = 0;
        gameOver = false;
    }
}
