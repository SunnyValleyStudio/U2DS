using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class AgentRenderer : MonoBehaviour
{
    protected SpriteRenderer spriteRenderer;

    [field: SerializeField]
    public UnityEvent<int> OnBackwardMovement { get; set; }

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void FaceDirection(Vector2 pointerinput)
    {
        var direction = (Vector3)pointerinput - transform.position;
        var result = Vector3.Cross(Vector2.up, direction);
        if(result.z > 0)
        {
            spriteRenderer.flipX = true;
        }else if(result.z < 0)
        {
            spriteRenderer.flipX = false;
        }
    }

    public void CheckIfBackwardMovement(Vector2 movementVector)
    {
        float angle = 0;
        if(spriteRenderer.flipX == true)
        {
            angle = Vector2.Angle(-transform.right, movementVector);
        }
        else
        {
            angle = Vector2.Angle(transform.right, movementVector);
        }
        Debug.Log(angle);
        if (angle > 90)
        {
            OnBackwardMovement?.Invoke(-1);
        }
        else
        {
            OnBackwardMovement?.Invoke(1);
        }
    }
}
