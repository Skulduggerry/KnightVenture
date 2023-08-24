using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartMenu : MonoBehaviour
{
    
    public void startGame()
    {
        if (NamenSpeichern.instance.myInputField != null)
        {
            SceneManager.LoadScene(1);
        }
            
    }

    public void scoreboard()
    {SceneManager.LoadScene(4);
    }

        
    // Start is called before the first frame update

}
