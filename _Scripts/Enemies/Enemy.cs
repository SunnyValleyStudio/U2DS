using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour, IHittable
{
    [field: SerializeField]
    public int Health { get; private set; } = 2;

    [field: SerializeField]
    public UnityEvent OnGetHit { get; set; }

    public void GetHit(int damage, GameObject damageDealer)
    {
        Health--;
        OnGetHit?.Invoke();
        if(Health<= 0)
        {
            Destroy(gameObject);
        }
    }
}
