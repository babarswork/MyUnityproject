using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : FightSimulation
{
    string name;
    int health;
    string regId;
    int bulets;
    int damage;
    int x;
    int y;
    int shield = 100;
    bool isKilled = false;
    int kills;
    bool isDefensive = false;
    public void InitilizeGame( string name, string RegId, int Health, int kills, int bulets, int damage, int x, int y)
    {
        this.name = name;
        regId = RegId;
        health = Health;
        this.kills = kills;
        this.damage = damage;
        this.bulets = bulets;
        this.x = x;
        this.y = y;
    }
    public void EquipWeapon()
    {

    }
    void Heal(int val)
    {
        if (!isKilled)
        {
            if (health + val > 100)
                health = 100;
            else
                health += val;
        }
    }
    public virtual void Attack(MainPlayer Enemy)
    {
        if (!isKilled)
        {
            Enemy.GetDamage(damage);
            DisplayInfo();
            Enemy.DisplayInfo();
        }
    }
    public void GetDamage( int v)
    {
        if (!isDefensive)
        {
            if (shield - v > 0)
            {
                shield -= v;
            }
            else if (shield < 1)
            {
                health -= v;
            }
            else
            {
                shield -= v;
                health = health + (shield);
            }
        }
        if (health < 1)
        {
            Destroy();
        }
    }
    private void PlayersBattle(MainPlayer enemy)
    {
        MainPlayer enemyPlayer = enemy;
        Attack(enemyPlayer);
    }
    void Destroy()
    {
        isKilled = true;
        Debug.Log("Destroyed");
    }
    public void MoveForward()
    {
        x++;
    }
    public void MoveBackward()
    {
        x--;
    }
    public void MoveRight()
    {
        y++;
    }
    public void MoveLeft()
    {
        y--;
    }
    public void Shoot()
    {
        bulets--;
    }
    public void DisplayInfo()
    {
        Debug.Log("PayerName =" + name);
        Debug.Log("ID=" + regId);
        Debug.Log("X = " + x);
        Debug.Log("Y = " + y);
        Debug.Log("Health =" + health);
        //Debug.Log("bulets = " + bulets);
    }
    public enum GunType { Rifle, Sniper, ShotGun, Pistol, Dagger };
}
