using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreboardLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<GameManager>().UpdatePlayerTexts();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
