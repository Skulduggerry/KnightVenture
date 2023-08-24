using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NamenSpeichern : MonoBehaviour
{ 
    public static NamenSpeichern instance;

    private void Awake()
    {
        if (instance == null)
     {
        instance = this;
        }
    }
    // Start is called before the first frame update
    public Text myText;
    public InputField myInputField;
    public void Absenden()
    {
        print(myText.text);
        print(myInputField.text);
    }
}
