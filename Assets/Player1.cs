using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MainPlayer
{
    MainPlayer playersGun;
    public void ChangeWeapon()
    {

    }

    public void AssignGun(MainPlayer weapon)
    {
        playersGun = weapon;
    }

    public void AttackFromGun(MainPlayer enemyPlayer)
    {
        playersGun.Attack(enemyPlayer);
    }
    public void StartFire()
    {
        //we can add the functionality when to fire
    }
}
