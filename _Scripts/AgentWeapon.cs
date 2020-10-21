using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentWeapon : MonoBehaviour
{
    protected float desiredAngle;

    [SerializeField]
    protected WeaponRenderer weaponRenderer;

    private void Awake()
    {
        weaponRenderer = GetComponentInChildren<WeaponRenderer>();
    }

    public virtual void AimWeapon(Vector2 pointerposition)
    {
        var aimDirection = (Vector3)pointerposition - transform.position;
        desiredAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        AdjustWeaponRendering();
        transform.rotation = Quaternion.AngleAxis(desiredAngle, Vector3.forward);
    }

    protected void AdjustWeaponRendering()
    {

        weaponRenderer?.FlipSprite(desiredAngle > 90 || desiredAngle < -90);
        weaponRenderer?.RenderBehindHead(desiredAngle < 180 && desiredAngle > 0);
    }
}
