using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class LeaderboardManager : MonoBehaviour
{
    public class PlayerScore
    {
        public string playerName;
        public int score;
    }

    public List<PlayerScore> playerScores = new List<PlayerScore>();
    public List<Text> playerTexts = new List<Text>();

    public void AddPlayerScore()
    {
        string playerName = "";
        int score = 0;

        PlayerScore newScore = new PlayerScore
        {
            playerName = playerName,
            score = score
        };

        playerScores.Add(newScore);
        playerScores = playerScores.OrderByDescending(p => p.score).Take(10).ToList(); // Sortieren und auf Top 10 beschränken

        UpdatePlayerTexts();
    }

    void UpdatePlayerTexts()
    {
        for (int i = 0; i < playerTexts.Count; i++)
        {
            if (i < playerScores.Count)
            {
                playerTexts[i].text = $"{playerScores[i].playerName}: {playerScores[i].score}";
            }
            else
            {
                playerTexts[i].text = "";
            }
        }
    }
}
