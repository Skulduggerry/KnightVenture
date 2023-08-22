using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDetection : MonoBehaviour
{
    public GameObject coin;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetType() == coin.GetType())
        {
            print("Grabbing coin..");

            AudioSource audioSource = other.GetComponent<AudioSource>(); // Hole die Audio Source vom aktuellen GameObject
            audioSource.PlayOneShot(audioSource.clip,1f); // Münzklang abspielen
            
            Destroy(other.gameObject);
        }
    }
}
