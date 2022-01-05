using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightSimulation : MonoBehaviour
{
    public MainPlayer AmirPlayer;
    public MainPlayer BabarsPlayer;
    Player1 Babar;

    private void Start()
    {
        Babar = new Player1();
        AmirPlayer = new MainPlayer();
        BabarsPlayer = new MainPlayer();

        MainPlayer enemyPlayer = new MainPlayer();

        enemyPlayer.MoveForward();
    }
    private void Update()
    {
        Fight();
    }
    void Fight()
    {
        MovementOfPlayers();
        AttackOfplayers();
    }
    IEnumerator Timer()
    {
        int remainingTime = 120;
        while (remainingTime > 0)
        {
            remainingTime--;
            yield return new WaitForSeconds(1);
        }
        //Babar.AssignGun(WeaponsFactory.GetGun(MainPlayer.GunType.Rifle));
    }
    void MovementOfPlayers()
    {
        if (Input.GetKey(KeyCode.UpArrow)) { AmirPlayer.MoveForward(); }
        if (Input.GetKey(KeyCode.DownArrow)) { AmirPlayer.MoveBackward(); }
        if (Input.GetKey(KeyCode.RightArrow)) { AmirPlayer.MoveRight(); }
        if (Input.GetKey(KeyCode.LeftArrow)) { AmirPlayer.MoveLeft(); }

        if (Input.GetKey(KeyCode.W)) { BabarsPlayer.MoveForward(); }
        if (Input.GetKey(KeyCode.S)) { BabarsPlayer.MoveBackward(); }
        if (Input.GetKey(KeyCode.D)) { BabarsPlayer.MoveRight(); }
        if (Input.GetKey(KeyCode.A)) { BabarsPlayer.MoveLeft(); }
    }
    void AttackOfplayers()
    {
        if (Input.GetKey(KeyCode.V)) { BabarsPlayer.Attack(AmirPlayer); }
        if (Input.GetKey(KeyCode.C)) { BabarsPlayer.Attack(BabarsPlayer); }
    }
}
