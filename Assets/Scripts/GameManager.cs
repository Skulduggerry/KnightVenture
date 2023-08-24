using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public int score = 0;

    public int highScore = 0;
    public int lifes = 3;

    private bool gameStarted = false;

    void Start()
    {
        if (gameStarted == false)
        {

            gameStarted = true;
            Debug.Log("Spiel wurde gestartet!");
            SceneManager.LoadScene(0);

        }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void DecreaseHealth()
    {
        --lifes;
        if(lifes == 0)
        {
            SceneManager.LoadScene("Lose", LoadSceneMode.Single);
        }
    }

    public void IncreaseScore(int amount)
    {
        score += amount;

        if (score > highScore)
        {
            highScore = score;
            print("New high score: " + highScore);
        }
    }
    private void Update()
    {
        // Überprüfe, ob das Spiel gestartet wurde
       

    }
}



    