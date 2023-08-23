using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    private Text textComponent;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        textComponent = GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        score = GameManager.instance.score;
        textComponent.text = "Score: " + score;
    }
}
