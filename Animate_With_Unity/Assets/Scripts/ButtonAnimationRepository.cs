using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimationRepository : MonoBehaviour
{
    public static ButtonAnimationRepository instance;

    [SerializeField]
    private List<ButtonAnimationEntry> animationEntries;

    private void Awake()
    {
        instance = this;
    }

    public string GetAnimationTriggerName(ButtonAnimation buttonAnimation)
    {
        foreach (ButtonAnimationEntry entry in animationEntries)
        {
            if (entry.animationName == buttonAnimation) return entry.triggerName;
        }
        return animationEntries[0].triggerName;
    }
}

[Serializable]
public struct ButtonAnimationEntry
{
    public string triggerName;
    public ButtonAnimation animationName;
}

public enum ButtonAnimation
{
    NORMAL,
    HIDDEN,
    POP_UP,
    POP_OUT,
    SLIDE_DOWN,
    SLIDE_UP,
    SHAKE,
    SCALE,
    ROTATE
}
