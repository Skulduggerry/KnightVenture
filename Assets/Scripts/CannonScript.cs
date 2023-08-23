using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{

    public GameObject player;
    public GameObject bullet;
    public float delay;
    public float strength = 20;
    public float explosionRadius = 5;
    private GameObject target;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        if (!target) return;

        Vector3 origin = transform.Find("SpawnPoint").position;
        Vector3 direction = target.transform.position - origin;
        transform.LookAt(target.transform);

        timer -= Time.deltaTime;
        if (timer > 0) return;

        /*RaycastHit[] result = Physics.RaycastAll(origin, direction, direction.magnitude);
        if(result.Length > 1 ) 
            return; */
        print("Spawn");
        timer = delay;
        GameObject spawned = Instantiate(bullet, origin, Quaternion.LookRotation(direction.normalized));
        spawned.GetComponent<Rigidbody>().AddExplosionForce(strength, transform.Find("ExplosionPoint").position, explosionRadius);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!player.CompareTag(other.gameObject.tag)) return;
        target = other.gameObject;
        timer = delay;
    }

    private void OnTriggerExit(Collider other)
    {
        if (!player.CompareTag(other.gameObject.tag)) return;
        target = null;
    }
}
