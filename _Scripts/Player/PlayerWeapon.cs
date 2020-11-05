using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : AgentWeapon
{
    [SerializeField]
    private UIAmmo uiAmmo = null;

    public bool AmmoFull { get => weapon != null && weapon.AmmoFull;}

    private void Start()
    {
        if (weapon != null)
        {
            weapon.OnAmmoChange.AddListener(uiAmmo.UdpateBulletsText);
            uiAmmo.UdpateBulletsText(weapon.Ammo);
        }

    }

    public void AddAmmo(int amount)
    {
        if (weapon != null)
            weapon.Ammo += amount;
    }
}
