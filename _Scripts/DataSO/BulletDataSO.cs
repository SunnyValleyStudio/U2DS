using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapons/BulletData")]
public class BulletDataSO : ScriptableObject
{
    public float Friction { get; internal set; }
    public float BulletSpeed { get; internal set; }
}
