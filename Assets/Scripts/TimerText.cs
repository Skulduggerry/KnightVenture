using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{
    public  Text timerText;
    public float timer = 45;
    // Start is called before the first frame update
    void Start()
    {
        timerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0f)
        {
            timer = 0;
            GameManager.instance.ToLose();

        }
        else
        {
            timer -= Time.deltaTime;
        }
        
        timerText.text = "Timer: " + Mathf.Round(timer * 100) / 100; ;
        
        
    }
}