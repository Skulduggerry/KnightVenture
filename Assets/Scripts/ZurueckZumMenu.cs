using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZurueckZumMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void neustart()
    {
        SceneManager.LoadScene(0);
    }
}
