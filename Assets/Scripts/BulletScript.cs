using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float despawnTime = 100;
    public float strength = 50;
    public float speed = 10;
    private bool hasHit = false;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        despawnTime -= Time.deltaTime;
        if(despawnTime <= 0)
            Destroy(gameObject);
    }

    public void OnPlayerCollision()
    {
        hasHit = true;
        rb.isKinematic = false;
        rb.useGravity = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (hasHit) return;

        hasHit = true;
        rb.isKinematic = false;
        rb.useGravity = true;

        print("Hit player");
    }
}
