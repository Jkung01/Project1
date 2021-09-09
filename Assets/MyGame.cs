using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MyGame : MonoBehaviour
{
    public Button okButton;

    public InputField answerField;
    // Start is called before the first frame update
    void Start()
    {
        print ("hello");
    }

    public void printName()
    {
        print(answerField.text);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
