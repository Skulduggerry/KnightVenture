using UnityEngine;

public class DeathManager : MonoBehaviour
{

    private void Update()
    {
        if (transform.position.y < -50)
        {
            GameManager.instance.ToLose();
        }
    }
}
