using UnityEngine;
using UnityEngine.Events;

public interface IAgent
{
    int Health { get; }
    UnityEvent OnDie { get; set; }
    UnityEvent OnGetHit { get; set; }

}