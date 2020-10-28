using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackPlayer : MonoBehaviour
{
    [SerializeField]
    private List<Feedback> feedbackToPlay = null;

    public void PlayFeedback()
    {
        FinishFeedback();
        foreach (var feedback in feedbackToPlay)
        {
            feedback.CreateFeedback();
        }
    }

    private void FinishFeedback()
    {
        foreach (var feedback in feedbackToPlay)
        {
            feedback.CompletePreviousFeedback();
        }
    }
}
