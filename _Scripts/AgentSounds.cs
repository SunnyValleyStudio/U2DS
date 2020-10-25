using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentSounds : AudioPlayer
{
    [SerializeField]
    private AudioClip hitClip = null, deathClip = null, voiceLineClip = null;

    public void PlayeHitSound()
    {
        PlayClipWithVariablePitch(hitClip);
    }

    public void PlayDeathSound()
    {
        PlayClip(deathClip);
    }

    public void PlayeVoiceSound()
    {
        PlayClipWithVariablePitch(voiceLineClip);
    }
}
