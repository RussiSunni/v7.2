using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public Camera cam;
    public string inputText = "text";
    public GameObject vocab;
    private TouchScreenKeyboard keyboard;
    public SpriteRenderer spriteRenderer;
    public Sprite cat;
    public Sprite apple;
    Color blue = Color.blue;
    Color red = Color.red;
    Color yellow = Color.yellow;
    Color green = Color.green;
    Color black = Color.black;
    Color white = Color.white;

    public InputField inputField;
    bool appleOnScreen;
    void Start()
    {
        // cam = GetComponent<Camera>();
    }


    public void CheckButton()
    {
        var fairy = GameObject.Find("Fairy");
        Fairy fairyScript = fairy.GetComponent<Fairy>();

        if (inputField.text == "apple")
        {
            spriteRenderer.sprite = apple;
            vocab.transform.position = new Vector2(-0.033f, 1.848f);
            fairyScript.Animation("isApple");
            appleOnScreen = true;
        }

        else if (inputField.text == "eat")
        {
            if (appleOnScreen)
            {
                vocab.transform.position = new Vector2(-0.128f, 2.941f);
                fairyScript.Animation("isEat");
            }
            else
            {
                // shake head
            }
        }

        else if (inputField.text == "cat")
        {
            appleOnScreen = false;
            spriteRenderer.sprite = cat;
            vocab.transform.position = new Vector2(1.73f, -3.48f);

            fairyScript.NoAnimation("isEat");
            fairyScript.NoAnimation("isApple");
        }
        // colours
        else if (inputField.text == "blue")
        {
            cam.backgroundColor = blue;
        }
        else if (inputField.text == "red")
        {
            cam.backgroundColor = red;
        }
        else if (inputField.text == "yellow")
        {
            cam.backgroundColor = yellow;
        }
        else if (inputField.text == "green")
        {
            cam.backgroundColor = green;
        }
        else if (inputField.text == "black")
        {
            cam.backgroundColor = black;
        }
        else if (inputField.text == "white")
        {
            cam.backgroundColor = white;
        }

    }
}