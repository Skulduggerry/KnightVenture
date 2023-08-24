using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public int score = 0;

    public int maxLifes = 7;
    public int lifes;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
            instance = this;
        }
        lifes = maxLifes;
    }

    public void ToMainMenu()
    {
        print("Load main menu");
        SceneManager.LoadScene("Menus", LoadSceneMode.Single);
    }

    public void ToLevel1()
    {
        print("Load level 1");
        SceneManager.LoadScene("Level 1", LoadSceneMode.Single);
    }

    public void ToWinScreen1()
    {
        print("Load win 1");
        SceneManager.LoadScene("NextLevel", LoadSceneMode.Single);
    }

    public void ToLevel2()
    {
        print("Load level 2");
        SceneManager.LoadScene("Scene", LoadSceneMode.Single);
    }

    public void ToWinScreen2()
    {
        print("Load win 2");
        SceneManager.LoadScene("Win", LoadSceneMode.Single);
    }

    public void ToLose()
    {
        print("Load lose");
        SceneManager.LoadScene("Lose", LoadSceneMode.Single);
    }

    public void gameCursor(bool gameCursor)
    {
        Cursor.visible = !gameCursor;
        Cursor.lockState = gameCursor ? CursorLockMode.Locked : CursorLockMode.None;
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
        Debug.Log("New score: " + score);
    }
}



    