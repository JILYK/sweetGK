using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllReserses : MonoBehaviour
{
    
    public Text mainWindowCoins;
    public Text mainWindowHearts;

    public static bool isPosibleChangeCoins(float valuechange, float multiplier = 1)
    {
        if ((Config.coins + (valuechange * multiplier)) </*=*/ 0)
        {
            Config.UIController.needBuyCoins();
            return false;
        }
        return true;
            
    }
    public static bool isPosibleChangeHearts(float valuechange)
    {

        if ((Config.hearts + valuechange) < 0)
        {
            Config.UIController.needBuyHearts();
            //StaticConfig.buyHearth.SetActive(true);
            return false;
        }
        return true;
    }
    public static void changeCoinsValue(float valuechange, float multiplier = 1)
    {
        if (!isPosibleChangeCoins(valuechange, multiplier))
        {
            //StaticConfig.buyCoin.SetActive(true);
            return;
        }

        Config.coins += valuechange * multiplier;
        //PlayerPrefs.SetFloat("ValueCoin", StaticConfig.coins);
        Config.SaveGame();
        Config.UIController.updateValueResurses();
    }
    
    public static void changeHeartsValue(int valuechange)
    {
        if (!isPosibleChangeHearts(valuechange))
        {
            //StaticConfig.buyHearth.SetActive(true);
            return;
        }
        Config.hearts += valuechange;
        //PlayerPrefs.SetFloat("ValueHearth", StaticConfig.hearts);
        Config.SaveGame();
        Config.UIController.updateValueResurses();
    }

    //public static void updateValueResurses()
    //{
    //    StaticConfig.mainWindowCoins.text = StaticConfig.coins.ToString();
    //    StaticConfig.mainWindowHearts.text = StaticConfig.hearts.ToString();
    //}
    // Start is called before the first frame update
    void Start()
    {

            //StaticConfig.mainWindowCoins = mainWindowCoins;
            //StaticConfig.mainWindowHearts = mainWindowHearts;
        //updateValueResurses();
    }

    public void LoseCoin(int valueLoseuCoin)
    {
        changeCoinsValue(valueLoseuCoin);
    }
    public void BuyCoin(int valueByuCoin)
    {
        //StaticConfig.AchivmentsControll.upAchivka(2);
        changeCoinsValue(valueByuCoin);
        
    }
    public void BuyHearth(int valueByuHearth)
    {
        changeHeartsValue(valueByuHearth);
    }

    public static void youWinOrdern()
    {
        //updateMbWin();
        Config.winWindowOrder.SetActive(true);
        if (Config.isWinOrder) return;
        Config.isWinOrder = true;

        Config.AchivmentsControll.checkAchivkaTwo(StaticConfig.winWindowCastle, StaticConfig.isWinOrder);
        Config.AchivmentsControll.upAchivka(1);
    }
    public static void youWinCastle()
    {
        
        //updateMbWin();
        //StaticConfig.winWindowCastle.SetActive(true);
        //if (StaticConfig.isWinCastle) return;
        //StaticConfig.isWinCastle = true;
        //StaticConfig.AchivmentsControll.upAchivka(1);

    }
    //public static void updateMbWin()
    //{
    //    foreach (Text elem in StaticConfig.mbWinTxt)
    //    {
    //        elem.text = StaticConfig.nbWin.ToString();
    //    }
    //}


}
