using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CollisionDetection : MonoBehaviour
{

    public GameObject bullet;
    public GameObject coin;
    private CapsuleCollider pistonCollider;

    private void Start()
    {
        pistonCollider = GetComponent<CapsuleCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(bullet.CompareTag(other.tag))
        {
            other.GetComponent<BulletScript>().OnPlayerHit();
            return;
        }

        if (coin.CompareTag(other.gameObject.tag))
        {
            print("Grabbing coin..");

            AudioSource audioSource = other.GetComponent<AudioSource>();
            StartCoroutine(PlaySoundAndDestroy(audioSource, other.gameObject));

            GameManager.instance.IncreaseScore(1); // Punktestand um 1 erhöhen
        }
    }

    private IEnumerator PlaySoundAndDestroy(AudioSource audioSource, GameObject coinObject)
    {
        audioSource.Play(); // Münzklang abspielen
        yield return new WaitForSeconds(audioSource.clip.length); // Warte bis der Sound zu Ende ist
        Destroy(coinObject); // Münze zerstören
    }
}
