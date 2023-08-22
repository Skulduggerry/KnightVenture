using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;

    public void IncreaseScore(int amount)
    {
        // Increase the score by the given amount
        score += amount;
    }
}
