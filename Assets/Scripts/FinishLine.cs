using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetType() == player.GetType())
        {
            print("Gewonnen");
            SceneManager.LoadScene(3);
        }
    }
}
