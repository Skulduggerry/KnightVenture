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
    }
}
