 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 20;
    public float jumpVelocity = 50;
    private Rigidbody rb;
    private bool isOnGround;
    public float gravityMultiplier = 2.0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movementVector = new Vector3(horizontal, 0, vertical) * (movementSpeed * Time.deltaTime);
        Vector3 newLocation = transform.position + movementVector;
        rb.MovePosition(newLocation);

        bool isJumping = Input.GetButtonDown("Jump");
        if (isJumping && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpVelocity, ForceMode.Impulse);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        isOnGround = false;
        print(isOnGround);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
        print(isOnGround);
    }
}
