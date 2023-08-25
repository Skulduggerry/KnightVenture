using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class CollisionDetection : MonoBehaviour
{

    public GameObject bullet;
    public GameObject coin;
    public GameObject crown;
    public GameObject sword;
    private CapsuleCollider pistonCollider;

    private void Start()
    {
        pistonCollider = GetComponent<CapsuleCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (bullet.CompareTag(other.tag))
        {
            other.GetComponent<BulletScript>().OnPlayerHit();
            return;
        }

        if (coin.CompareTag(other.tag))
        {
            print("Grabbing coin..");
            GameManager.instance.PickupCoin(other.transform.position); // Punktestand um 1 erhöhen
            Destroy(other.gameObject);
            return;
        }

        if (sword.CompareTag(other.tag))
        {
            print("Nächstes Level");
            GameManager.instance.ToWinScreen1();
            return;
        }

        if (crown.CompareTag(other.tag))
        {
            print("Gewonnen");
            GameManager.instance.ToWinScreen2();
        }
    }
}
