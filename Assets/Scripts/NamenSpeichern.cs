using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NamenSpeichern : MonoBehaviour
{
    public Text myText;
    public InputField myInputField;
    public static NamenSpeichern instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update

    public void Absenden()
    {
        print(myText.text);
        print(myInputField.text);
    }
}
