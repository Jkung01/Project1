using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MyGame : MonoBehaviour
{
    public Button okButton;

    public Button restartbutton;

    public InputField answerField;

    public Text displayText;

    string[] answers;

    string[] TextA;

    int NumberA = 0;

    int QestionB = 0;

    // Start is called before the first frame update
    void Start()
    {
        restartbutton.gameObject.SetActive(false);
        answers = new string[3];
        TextA= new string[]{
            "ใส่ชื่อของคุณ",
            "ใส่อาหารที่ชอบ",
            "สัตว์ที่ชอบ",
            "ชอบเกมส์อะไร",
            "ชอบเล่นเกมส์คอมหรือมือถือ",
            "ชอบไปเที่ยวหรืออยู่บ้าน",
            "ชอบสีอะไร",
            "ชอบทะเลหรือภูเขา",
            "ชอบอากาศร้อนหรือหนาว",
        };



        displayText.text = TextA[QestionB];
    }

    public void printName()
    {
        answers[NumberA] = answerField.text;

        answerField.text = "";

        NumberA = NumberA + 1;

        QestionB = Random.Range(1,TextA.Length);

        if(NumberA <= 2)
        {

            displayText.text = TextA[QestionB];

        }
        else
        {
           displayText.text = answers[0] + 
                    "ชอบ" + answers[1] + 
                    "และชอบ" + answers[2] ;

            okButton.gameObject.SetActive(false);
            answerField.gameObject.SetActive(false);
            restartbutton.gameObject.SetActive(true);
        }
        
    }

    public void restart(){

        SceneManager.LoadScene("W4");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
