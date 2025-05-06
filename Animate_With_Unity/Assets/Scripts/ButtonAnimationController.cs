using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimationController : MonoBehaviour
{
    public static ButtonAnimationController instance;

    private string triggerName;
    private ButtonAnimationRepository buttonRepository;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        buttonRepository = ButtonAnimationRepository.instance;
    }

    public void PlayButtonAnimation(ButtonAnimation buttonAnimation, Animator buttonAnimator)
    {
        triggerName = buttonRepository.GetAnimationTriggerName(buttonAnimation);
        buttonAnimator.SetTrigger(triggerName);
    }
}


