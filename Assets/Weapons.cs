using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons
{
    string weaponId;
    string weaponName;
    int weaponPower;
    public enum weaponType {Rifle};
    weaponType GunType;

    public void InintializeWeapon(string WeaponId, string WeaponName, weaponType type)
    {
        weaponId = WeaponId;
        weaponName = WeaponName;
    }
    public Weapons Equip(Weapons.weaponType type, Rifle.RifleType rifleType)
    {
        return WeaponsFactory.GetGun(type, rifleType);
    }
}
