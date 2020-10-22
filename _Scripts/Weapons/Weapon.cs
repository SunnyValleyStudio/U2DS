using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    protected GameObject muzzle;

    [SerializeField]
    protected int ammo = 10;

    [SerializeField]
    protected WeaponDataSO weaponData;

    public int Ammo
    {
        get { return ammo; }
        set {
            ammo = Mathf.Clamp(value, 0, weaponData.AmmoCapacity);
        }
    }

    public bool AmmoFull { get => Ammo >= weaponData.AmmoCapacity; }

    [field: SerializeField]
    public UnityEvent OnShoot { get; set; }

    [field: SerializeField]
    public UnityEvent OnShootNoAmmo { get; set; }

    private void Start()
    {
        Ammo = weaponData.AmmoCapacity;
    }

    public void Shoot()
    {
        Debug.Log("Shooting");
    }
    public void StopShooting()
    {
        Debug.Log("Stop shooting");
    }

}
