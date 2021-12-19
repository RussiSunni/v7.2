using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fairy : MonoBehaviour
{
    public Animator animator;
    public void Animation(string word)
    {
        animator.SetBool(word, true);
    }

    public void NoAnimation(string word)
    {
        animator.SetBool(word, false);
    }
}
