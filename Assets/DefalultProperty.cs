using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefalultProperty : MonoBehaviour
{
    // Start is called before the first frame update

    public int a1v = 0;
    public int a2v = 0;
    public int a3v = 0;
    public int a4v = 0;
    //public  


    public bool a1bool = false;
    public bool a2bool = false;
    public bool a3bool = false;
    public bool a4bool = false;


    public bool isAchivments_1 = false;
    public bool isAchivments_2 = false;
    public bool isAchivments_3 = false;
    public bool isAchivments_4 = false;

    public float coins = 10000;
    public int hearts = 5;

    public int currentStreak;
    public string lastLogin;
    public bool isRewardGot;

    public bool IsWonCastleGame = false;
    public bool IsWonOrderGame = false;

    public void def()
    {
        Config.coins = coins;
        Config.hearts = hearts;
        Config.a1v = a1v;
        Config.a2v = a2v;
        Config.a3v = a3v;
        Config.a4v = a4v;
        Config.a1bool = a1bool;
        Config.a2bool = a2bool;
        Config.a3bool = a3bool;
        Config.a4bool = a4bool;

        Config.currentStreak = currentStreak;
        Config.lastLogin = lastLogin;
        Config.isRewardGot = isRewardGot;

        Config.IsWonCastleGame = IsWonCastleGame;
        Config.IsWonOrderGame = IsWonOrderGame;
        Config.SaveGame();


        //Config.SaveLoadManager.saveGame();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
