using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMenuText : MonoBehaviour {

    public GameObject Text0;
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;
    public GameObject Text4;
    public GameObject Text5;
    public GameObject Text6;
    public GameObject Text7;
    public GameObject Text8;

    public Text Menu;
    public MeganEvents megTest;
    int textCount;

    // Use this for initialization
    void Start() {
        Text0.SetActive(false);
        Text1.SetActive(false);
        Text2.SetActive(false);
        Text3.SetActive(false);
        textCount = 0;
        Debug.Log(textCount);
        Menu.GetComponent<Text>().text = Text0.GetComponent<TextMesh>().text;

    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            megTest.changeAnimation("Thoughtful"); 
        }
    }

    // Update is called once per frame

    public void updateText(string response) {
        if (Input.GetKeyDown ("space") || response == "The pharmacist is refusing to fill my medication. I'm trying to explain it to her, that I need my medication now." ||
            response == "No, I don't have any weapons on me." ||
            response == "No, I have not taken any drugs today." ||
            response == "No, I haven't had anything to drink either. I need my medication, is there anybody that can help me?"||
            response == "Thank you, officer. I'm overwhelmed because this pharmacist isn't helping me refill my medication. I'm going through a panic attack because I don't have my medication, and it seems like nobody understands how serious this is!"||
            response == "Okay, but I need my medication after. These panic attacks get so intense, I - I just don't feel in control without my pills."||
            response == "Yes, that's exactly it. Can you explain that to the pharmacist?"||
            response == "I just can't get my medication otherwise! Look, all I need is one refill. That's it!"||
            response == "Okay we can move to another room. But I am not leaving the pharmacy until I get my refill.")
        {
            //megTest.changeAnimation("Thoughtful");
            textCount++;
            Debug.Log(textCount);
        }

        if (textCount == 0)
        {
            megTest.changeAnimation("Thoughtful");
            Menu.GetComponent<Text>().text = Text0.GetComponent<TextMesh>().text;
        }
        else if (textCount == 1)
        {
            megTest.changeAnimation("Happy");
            Menu.GetComponent<Text>().text = Text1.GetComponent<TextMesh>().text;
            //Text0.SetActive(false);
            //Text1.SetActive(true);
            megTest.playAudio("LipTest");
        }
        else if (textCount == 2)
        {
            megTest.changeAnimation("Thoughtful");
            Menu.GetComponent<Text>().text = Text2.GetComponent<TextMesh>().text;
        }
        else if (textCount == 3)
        {
            megTest.changeAnimation("Thoughtful");
            Menu.GetComponent<Text>().text = Text3.GetComponent<TextMesh>().text;
        }
        else if (textCount == 4)
        {
            megTest.changeAnimation("Thoughtful");
            Menu.GetComponent<Text>().text = Text4.GetComponent<TextMesh>().text;
        }
        else if (textCount == 5)
        {
            megTest.changeAnimation("Happy");
            Menu.GetComponent<Text>().text = Text5.GetComponent<TextMesh>().text;
        }
        else if (textCount == 6)
        {
            megTest.changeAnimation("Thoughtful");
            Menu.GetComponent<Text>().text = Text6.GetComponent<TextMesh>().text;
        }
        else if (textCount == 7)
        {
            Menu.GetComponent<Text>().text = Text7.GetComponent<TextMesh>().text;
        }
        else if (textCount == 8)
        {
            Menu.GetComponent<Text>().text = Text8.GetComponent<TextMesh>().text;
        }
        else
        {
            textCount = 0;
        }
    }
}
		
	

