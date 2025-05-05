using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonHandler : MonoBehaviour
{

    private Button button;
    [SerializeField] private ButtonAnimation animationToPlay;

    private AnimationController animationController;

    private void Start()
    {
        animationController = AnimationController.instance;
        button = GetComponent<Button>();
        button.onClick.AddListener(PlayButtonAnimation);

    }
    private void PlayButtonAnimation()
    {
        animationController.PlayButtonAnimation(animationToPlay);
    }
}
