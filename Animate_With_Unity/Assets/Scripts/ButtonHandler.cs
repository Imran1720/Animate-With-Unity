using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonHandler : MonoBehaviour
{

    private Button button;
    [SerializeField] private ButtonAnimation animationToPlay;
    private Animator animator;

    private ButtonAnimationController animationController;

    private void Start()
    {
        Initialize();
        button.onClick.AddListener(PlayButtonAnimation);
    }

    private void Initialize()
    {
        animationController = ButtonAnimationController.instance;
        animator = GetComponent<Animator>();
        button = GetComponent<Button>();
    }

    private void PlayButtonAnimation()
    {
        animationController.PlayButtonAnimation(animationToPlay, animator);
    }
}
