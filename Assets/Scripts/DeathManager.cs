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
            SceneManager.LoadScene(2);

        }
    }
}
