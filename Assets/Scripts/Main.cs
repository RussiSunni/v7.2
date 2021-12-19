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
    public Sprite cat, chicken, dog, duck, frog, apple;
    Color blue = Color.blue;
    Color red = Color.red;
    Color yellow = Color.yellow;
    Color green = Color.green;
    Color black = Color.black;
    Color white = Color.white;
    public InputField inputField;
    private FairyState fairyState = FairyState.idle;
    void Start()
    {
        // cam = GetComponent<Camera>();
    }
    public void CheckButton()
    {
        var fairy = GameObject.Find("Fairy");
        Fairy fairyScript = fairy.GetComponent<Fairy>();


        switch (fairyState)
        {
            case FairyState.idle:
                fairyScript.NoAnimation("isApple");
                fairyScript.NoAnimation("isFrog");


                if (inputField.text == "apple")
                {
                    spriteRenderer.sprite = apple;
                    vocab.transform.position = new Vector2(-0.033f, 1.848f);
                    fairyScript.Animation("isApple");  
                    
                    fairyState = FairyState.apple;                    
                }

                // animals
                else if (inputField.text == "cat")
                {                   
                    spriteRenderer.sprite = cat;
                    vocab.transform.position = new Vector2(1.73f, -3.48f);  
                }
                else if (inputField.text == "chicken")
                {
                    spriteRenderer.sprite = chicken;
                    vocab.transform.position = new Vector2(0.92f, -2.96f);
                }
                else if (inputField.text == "dog")
                {                    
                    spriteRenderer.sprite = dog;
                    vocab.transform.position = new Vector2(0.0f, -2.97f);
                }
                else if (inputField.text == "duck")
                {
                    spriteRenderer.sprite = duck;
                    vocab.transform.position = new Vector2(0.9f, -2.53f);
                }

                else if (inputField.text == "frog")
                {
                    spriteRenderer.sprite = frog;
                    vocab.transform.position = new Vector2(-0.1f, 1.58f);
                    fairyScript.Animation("isFrog");

                    fairyState = FairyState.frog;
                }
               
                //verbs
                else if (inputField.text == "kiss")
                {
                    // shake head
                }
                else if (inputField.text == "eat")
                {
                    // shake head
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

                break;


            case FairyState.apple:
                if (inputField.text == "eat")
                {
                    vocab.transform.position = new Vector2(-0.128f, 2.941f);
                    fairyScript.Animation("isEat");
                }
                else
                {
                    fairyState = FairyState.idle;
                    CheckButton();
                }

                break;


            case FairyState.frog:
                if (inputField.text == "kiss")
                {
                    vocab.transform.position = new Vector2(-0.1f, 2.8f);
                    fairyScript.Animation("isKiss");                   
                }
                else
                {
                    fairyState = FairyState.idle;
                    CheckButton();
                }

                break;

        }

        print(fairyState);
    }


    public enum FairyState
    {
        idle,
        apple,
        frog
    }
}