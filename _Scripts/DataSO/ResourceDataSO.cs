using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Items/ResourceData")]
public class ResourceDataSO : ScriptableObject
{
    [field: SerializeField]
    public ResourceTypeEnum ResourceType { get; set; }
    [SerializeField]
    private int minAmount = 1, maxAmount = 5;

    public int GetAmount()
    {
        return Random.Range(minAmount, maxAmount + 1);
    }
}

public enum ResourceTypeEnum
{
    None,
    Health,
    Ammo
}
