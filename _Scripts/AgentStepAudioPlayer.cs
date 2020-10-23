using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AgentStepAudioPlayer : AudioPlayer
{

    [SerializeField]
    protected AudioClip stepClip;

    public void PlayStepSound()
    {
        PlayClipWithVariablePitch(stepClip);
    }
}
