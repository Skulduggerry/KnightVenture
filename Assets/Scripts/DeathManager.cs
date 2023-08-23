using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour
{

    private void Update()
    {
        if (transform.position.y < -50)
        {
            print("Du hast leider verloren!");
            SceneManager.LoadScene(2);

        }
    }
}
