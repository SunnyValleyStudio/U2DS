using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeFeedback : Feedback
{
    [SerializeField]
    private GameObject objectToShake = null;
    [SerializeField]
    private float duration = 0.2f, strength = 1, randomness = 90;
    [SerializeField]
    private int vibrato = 10;
    [SerializeField]
    private bool snapping = false, fadeout = true;

    public override void CompletePreviousFeedback()
    {
        objectToShake.transform.DOComplete();
    }

    public override void CreateFeedback()
    {
        CompletePreviousFeedback();
        objectToShake.transform.DOShakePosition(duration, strength, vibrato, randomness, snapping, fadeout);
    }
}
