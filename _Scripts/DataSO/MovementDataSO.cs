using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Agent/MovementData")]
public class MovementDataSO : ScriptableObject
{
    [Range(1,10)]
    public float maxSpeed = 5;

    [Range(0.1f,100)]
    public float acceleration = 50, deacceleration = 50;
}
