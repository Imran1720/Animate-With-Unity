using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public static AnimationController instance;

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
        Debug.Log(buttonAnimator == null);
        triggerName = buttonRepository.GetAnimationTriggerName(buttonAnimation);
        buttonAnimator.SetTrigger(triggerName);
    }
}


