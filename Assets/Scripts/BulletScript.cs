using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float despawnTime = 100;
    public float strength = 50;
    public float speed = 10;
    public GameObject player;
    private bool hasHit = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        despawnTime -= Time.deltaTime;
        if(despawnTime <= 0)
            Destroy(gameObject);
    }

    public void OnPlayerHit()
    {
        if (hasHit) return;
        hasHit = true;
        GameManager.instance.DecreaseHealth();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (hasHit) return;

        rb.isKinematic = false;
        rb.useGravity = true;
        hasHit = true;
    }
}
