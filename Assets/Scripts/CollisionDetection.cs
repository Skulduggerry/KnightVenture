using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{

    public GameObject bullet;
    private CharacterController controller;
    private float distance;
    private int platLayer;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        distance = controller.radius + 0.2f;
        platLayer = LayerMask.NameToLayer("Moving");
    }

    public void FixedUpdate()
    {
        RaycastHit hit;

        Vector3 p1 = transform.position + Vector3.up * 0.25f;
        Vector3 p2 = p1 + Vector3.up * controller.height;

        for(int i = 0; i < 360; i += 36)
        {
            if (Physics.CapsuleCast(p1, p2, 0, new Vector3(Mathf.Cos(i), 0, Mathf.Sin(i)), out hit, 1<<platLayer))
            {
                controller.Move(hit.normal * (distance - hit.distance));
            }
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (bullet.CompareTag(hit.gameObject.tag))
        {
            bullet.gameObject.GetComponent<BulletScript>().OnPlayerCollision();
            print("Leben verlieren");
        }
    }
}
