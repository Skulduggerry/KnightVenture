using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour
{ 
    public float rotationSpeed = 100f;
    public float movementSpeed = 1f;
    public float minHeight = 0f;
    public float maxHeight = 1f;
    private int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up * angle, Space.World);

        if(transform.position.y >= maxHeight)
        {
            direction = -1;
        } else if(transform.position.y <= minHeight)
        {
            direction = 1;
        }

        float movementDistance = movementSpeed * direction * Time.deltaTime;
        transform.Translate(Vector3.up * movementDistance, Space.World);
    }
}
