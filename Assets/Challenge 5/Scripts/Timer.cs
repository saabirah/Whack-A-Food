using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float timeLeft;
    private bool timeOn = false;
    private Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timeOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeOn)
        {
            if(timeLeft>0) 
            {
                timeLeft -= Time.deltaTime;
                UpdateTimer(timeLeft);
            }
            else
            {
                Debug.Log("Game over");
                timeLeft = 0;
                timeOn = false;
            }
        }
        
    }

    void UpdateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float secondes = Mathf.FloorToInt(currentTime % 60);
        timerText.text = string.Format("(0:00) : (1:00)", minutes, secondes);
    }
}
