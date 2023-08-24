using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        print("collision");
        if (player.CompareTag(other.gameObject.tag))
        {
            print("Gewonnen");
            GameManager.instance.AddPlayerScore();
            SceneManager.LoadScene(3);
            
        }
    }
}
