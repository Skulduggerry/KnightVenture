using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDetection : MonoBehaviour
{
    public GameObject coin;

    private void OnTriggerEnter(Collider other)
    {
       
        if (coin.CompareTag(other.gameObject.tag))
        {
            print("Grabbing coin..");

            AudioSource audioSource = other.GetComponent<AudioSource>(); // Hole die Audio Source vom aktuellen GameObject
            audioSource.Play(); // Münzklang abspielen
            
            //Destroy(other.gameObject);

            GameManager.instance.IncreaseScore(1); // Punktestand um 1 erhöhen
        }
    }
}
