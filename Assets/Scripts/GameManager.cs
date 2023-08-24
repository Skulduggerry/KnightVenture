using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public int score = 0;
    public string playerName;

    public int highScore = 0;
    public int maxLifes = 3;
    private int lifes;

    private bool gameStarted = false;

    void Start()
    {
        if (gameStarted == false)
        {
            gameStarted = true;
            score = 0;
            lifes = maxLifes;
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
        Debug.Log($"Lifes {lifes}");
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

    public class PlayerScore
    {
        public string playerName;
        public int playerScore;
    }

    public static List<PlayerScore> playerScores = new List<PlayerScore>();
    public List<Text> playerTexts;

    public void AddPlayerScore()
    {
        string playerName = "__";
        int score1 = score;

        PlayerScore newScore = new PlayerScore
        {
            playerName = playerName,
            playerScore = score1
        };

        playerScores.Add(newScore);
        playerScores = playerScores.OrderByDescending(p => p.playerScore).Take(5).ToList(); // Sortieren und auf Top 10 beschränken
    }

    public void UpdatePlayerTexts()
    {
        for (int i = 0; i < playerTexts.Count; i++)
        {
            if (i < playerScores.Count)
            {
                playerTexts[i].text = $"{playerScores[i].playerName}: {playerScores[i].playerScore}";
            }
            else
            {
                playerTexts[i].text = "";
            }

        }
    }
}



    