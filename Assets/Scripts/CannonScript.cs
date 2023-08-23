using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonScript : MonoBehaviour
{

    public GameObject player;
    public GameObject bullet;
    public float delay;
    public float strength = 15;
    private GameObject target;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        if (!target) return;

        Vector3 origin = transform.Find("SpawnPoint").position;
        Vector3 dest = target.transform.position;
        dest.y += target.GetComponent<CharacterController>().height / 2;
        Vector3 direction = dest - origin;
        transform.LookAt(target.transform);

        timer -= Time.deltaTime;
        if (timer > 0) return;

        print("Spawn");
        timer = delay;
        GameObject spawned = Instantiate(bullet, origin, Quaternion.LookRotation(direction.normalized));
        spawned.GetComponent<Rigidbody>().AddForce(direction.normalized * strength, ForceMode.Impulse);
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
