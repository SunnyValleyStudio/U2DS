using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AIAction : MonoBehaviour
{
    protected AIActionData aiActionData;
    protected AIMovementData aiMovementData;
    protected EnemyAIBrain enemyBrain;

    private void Awake()
    {
        aiActionData = transform.root.GetComponentInChildren<AIActionData>();
        aiMovementData = transform.root.GetComponentInChildren<AIMovementData>();
        enemyBrain = transform.root.GetComponent<EnemyAIBrain>();
    }

    public abstract void TakeAction();
}
