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
    void Start()
    {
        cam = GetComponent<Camera>();         
    }

    void Update ()
    {   
        if(Input.touchCount > 0)
        {
            keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default, false, false, false, true);
        }
    }

    void OnGUI()
    {
        if (keyboard != null)
            inputText = keyboard.text;

        if (inputText=="cat")
        {
           spriteRenderer.sprite = cat; 
           vocab.transform.position = new Vector2(1.73f, -3.48f);
        }
        // colours
        else if (inputText=="blue")
        {
            cam.backgroundColor = blue;   
        }
         else if (inputText=="red")
        {
            cam.backgroundColor = red;   
        }
         else if (inputText=="yellow")
        {
            cam.backgroundColor = yellow;   
        }
         else if (inputText=="green")
        {
            cam.backgroundColor = green;   
        }
        else if (inputText=="black")
        {
            cam.backgroundColor = black;   
        }
         else if (inputText=="white")
        {
            cam.backgroundColor = white;   
        }
        else if (inputText=="apple")
        {
            spriteRenderer.sprite = apple;  
            vocab.transform.position = new Vector2(-2.4f, 2);
        }              
    }
}