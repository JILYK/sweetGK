using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Config : MonoBehaviour
{
    #region CASTLE

    public static Sprite[] stateCastlePlayList = new Sprite[3];
    public static Sprite[] SweetsCastlePlayList = new Sprite[13];
    static public float[] percentList = new float[5];
    static public ElemScripts[,] allElemCastleList = new ElemScripts[3, 6];
    public static int currentActiveStringCastlePlay = 0;

    #endregion

    public static UIController UIController;


    public static float coins;
    public static int hearts;
    public static float currentStavka = 0;
    public static float posibleWin = 0;
    public static Animator gridAnimator;

    public static GridOrderScript gridOrderScript;

    public static int diffictly;

    public static List<OrderItem> yesListStatic;
    public static OrderItem currentOrderItem;

    public static int valueIncognitoElem;

    public static AudioSource AudioSource;
    // Start is called before the first frame update 

    public static AchivmentsControll AchivmentsControll;

    public static int currentStreak;
    public static string lastLogin;
    public static bool isRewardGot;


    public static int a1v;
    public static int a2v;
    public static int a3v;
    public static int a4v;

    public static bool a1bool;
    public static bool a2bool;
    public static bool a3bool;
    public static bool a4bool;


    public static int starRating;
    public static bool IsWonCastleGame;
    public static bool IsWonOrderGame;

    //----------------------------------------------


    public static GameObject buyCoin;
    public static GameObject buyHearth;
    public static GameObject miniPause;
    public static GameObject loseWindowCastle;
    public static GameObject winWindowOrder;
    public static GameObject winWindowCastle;
    public static Text valueWinCoins;
    public static float nbWin;


    public static bool isWinCastle = false;
    public static bool isWinOrder = false;


    public static Text mainWindowCoins;
    public static Text mainWindowHearts;


    //-----------------------------------------------

    public static int boolToInt(bool val)
    {
        if (val) return 1;
        else return 0;
    }

    public static bool intToBool(int val)
    {
        if (val != 0) return true;
        else return false;
    }


    public static void SaveGame()
    {
        PlayerPrefs.SetFloat("coins", coins);
        PlayerPrefs.SetInt("hearts", hearts);
        PlayerPrefs.SetInt("currentStreak", currentStreak);
        PlayerPrefs.SetString("lastLogin", lastLogin);
        PlayerPrefs.SetInt("isRewardGot", boolToInt(isRewardGot));
        PlayerPrefs.SetInt("starRating", starRating);


        PlayerPrefs.SetInt("a1v", a1v);
        PlayerPrefs.SetInt("a2v", a2v);
        PlayerPrefs.SetInt("a3v", a3v);
        PlayerPrefs.SetInt("a4v", a4v);

        PlayerPrefs.SetInt("a1bool", boolToInt(a1bool));
        PlayerPrefs.SetInt("a2bool", boolToInt(a2bool));
        PlayerPrefs.SetInt("a3bool", boolToInt(a3bool));
        PlayerPrefs.SetInt("a4bool", boolToInt(a4bool));

        PlayerPrefs.SetInt("IsWonCastleGame", boolToInt(IsWonCastleGame));
        PlayerPrefs.SetInt("IsWonOrderGame", boolToInt(IsWonOrderGame));
    }

    public static void LoadGame()
    {
        coins = PlayerPrefs.GetFloat("coins");
        hearts = PlayerPrefs.GetInt("hearts");
        currentStreak = PlayerPrefs.GetInt("currentStreak");
        lastLogin = PlayerPrefs.GetString("lastLogin");
        isRewardGot = intToBool(PlayerPrefs.GetInt("isRewardGot"));
        starRating = PlayerPrefs.GetInt("starRating", -1);


        a1v = PlayerPrefs.GetInt("a1v");
        a2v = PlayerPrefs.GetInt("a2v");
        a3v = PlayerPrefs.GetInt("a3v");
        a4v = PlayerPrefs.GetInt("a4v");

        a1bool = intToBool(PlayerPrefs.GetInt("a1bool"));
        a2bool = intToBool(PlayerPrefs.GetInt("a2bool"));
        a3bool = intToBool(PlayerPrefs.GetInt("a3bool"));
        a4bool = intToBool(PlayerPrefs.GetInt("a4bool"));

        IsWonCastleGame = intToBool(PlayerPrefs.GetInt("IsWonCastleGame"));
        IsWonOrderGame = intToBool(PlayerPrefs.GetInt("IsWonOrderGame"));
    }
}