using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZurAnfangsSzene : MonoBehaviour
{
    public string targetSceneName = "Menus";

    private void Start()
    {
        // Überprüfe, ob der Name der aktuellen Szene dem Zielnamen entspricht
        if (SceneManager.GetActiveScene().name != targetSceneName)
        {
            // Führe hier Aktionen aus, die du bei der bestimmten Szene machen möchtest
           
            Debug.Log("Aktuelle Szene ist nicht die gewünschte Szene.");
            SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("Aktuelle Szene ist die gewünschte Szene: " + targetSceneName);
        }

    }


}
