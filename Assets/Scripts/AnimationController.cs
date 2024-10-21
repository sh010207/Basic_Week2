using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationController : MonoBehaviour
{
    public static AnimationController instance;

    private int animationVariable = 0;
    private Animator _animator;

    // _animator 세팅 
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        _animator = GetComponent<Animator>();
    }

    public void OnMouseDown()
    {
        animationVariable++;

        if (animationVariable == 3)
        {
            animationVariable = 0;
        }
        // animationVariable을 수정
        _animator.SetInteger("State", animationVariable);
    }
}
