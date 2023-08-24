using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreboardLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<LeaderboardManager>().UpdatePlayerTexts();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
