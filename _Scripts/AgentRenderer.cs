using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class AgentRenderer : MonoBehaviour
{
    protected SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Debug.Log("Right cross product " + Vector3.Cross(Vector2.up, Vector2.right));
        Debug.Log("Left cross product " + Vector3.Cross(Vector2.up, -Vector2.right));
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
}
