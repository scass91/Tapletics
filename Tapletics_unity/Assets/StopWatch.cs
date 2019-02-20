using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StopWatch : MonoBehaviour
{

    float timer;
    float milliseconds;
    float seconds;
    float minutes;

    [SerializeField] Text stopWatchText;
    // Start is called before the first frame update
    void Start()
    {
        timer = -3;

    }

    // Update is called once per frame
    void Update()
    {
        //timer.Thread.Sleep(3000);
        WatchCalculator();
    }

    void WatchCalculator()
    {

        timer += Time.deltaTime;
        milliseconds = (int)((timer * 1000) % 1000);
        seconds = (int)(timer % 60);
        minutes = (int)(timer / 60);

        stopWatchText.text = minutes.ToString("00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");
    }
}