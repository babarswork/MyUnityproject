using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponsFactory
{
    public static Weapons GetGun(Weapons.weaponType type, Rifle.RifleType rifleType)
    {
        switch (type)
        {
            case Weapons.weaponType.Rifle:
                //return WeaponsFactory.(rifleType);
            //case MainPlayer.GunType.:
              //  return ;
            //case MainPlayer.GunType.:
            //    return ;
            default:
                return new Weapons();
        }
    }

}
