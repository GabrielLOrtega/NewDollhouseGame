using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider : MonoBehaviour
{
    public Slider timerSlider;
    public float sliderTimer;
    public bool stopTimer = false;

    void Start()
    {
        timerSlider.maxValue = 30f;
        timerSlider.value = sliderTimer;
            StartTimer();

    }
    public void StartTimer() => StartCoroutine(StartTheTimerTicker());



    IEnumerator StartTheTimerTicker()
    {


        while (stopTimer == false)
        {
            sliderTimer -= Time.deltaTime;
            yield return new WaitForSeconds(0.001f);

            if (sliderTimer <= 0)
            {
                stopTimer = true;
                if (stopTimer == false)
                {
                    Debug.Log("stoptimer=false");
                }
            }
            if (stopTimer == false)
            {
                timerSlider.value = sliderTimer;
            }

        }  
     //add game logic / respawn character logic
     
 
    }

    public void StopTimer()
    {
        stopTimer = true;
    }
}