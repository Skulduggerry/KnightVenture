using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{

    private void Update()
    {
        if (transform.position.y < -10)
        {
            print("Du hast leider verloren!");

        }
    }
}
