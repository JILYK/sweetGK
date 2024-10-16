using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControllCastlePlay : MonoBehaviour
{
    
    public static void blockAllbuttons()
    {
        for (int i = 0; i < 6; i++)
        {
            for (int k = 0; k < 3; k++)
            {
                //StaticConfig.allElemcastleList[k, i].interectble(false);
                Config.allElemCastleList[k, i].interectble(false);
            }
        }
    }
    public static void clouseString(ElemScripts elemPanel)
    {
        for (int k = 0; k < 3; k++)
        {
            Config.allElemCastleList[k, Config.currentActiveStringCastlePlay - 1].currentButtonImage.sprite = Config.stateCastlePlayList[2];
        }
        elemPanel.currentButtonImage.sprite = Config.stateCastlePlayList[0];
        elemPanel.childrenImage.sprite = Config.SweetsCastlePlayList[UnityEngine.Random.Range(1, 13)];
        nextString();
    }
    public static void nextString()
    {
        if (Config.currentActiveStringCastlePlay > 5)
        {
            Config.posibleWin = Config.currentStavka * Config.percentList[Config.currentActiveStringCastlePlay - 1];
            Config.UIController.winCastleGame();
            return;
        }
        blockAllbuttons();

        for (int k = 0; k < 3; k++)
        {
            Config.allElemCastleList[k, Config.currentActiveStringCastlePlay].interectble(true);
            Config.allElemCastleList[k, Config.currentActiveStringCastlePlay].currentButtonImage.sprite = Config.stateCastlePlayList[1];
        }
        if (Config.currentActiveStringCastlePlay==2)
        {

            Config.gridAnimator.GetComponent<Animator>().SetBool("BackUp", false);
        }
        if (Config.currentActiveStringCastlePlay > 0) 
        {
            //StaticConfig.GridCastleScript.collectNow.gameObject.SetActive(true);

            //Config.UIController.winCastleGame();
            /// ПЕРЕПИСАТЬ
            /// 
            
            Config.posibleWin = Config.currentStavka * Config.percentList[Config.currentActiveStringCastlePlay - 1];
            Config.UIController.updateText();
            /// ПЕРЕСМОТРЕТЬ
            //ControllReserses.updateMbWin();
        }
        else
        {
            Config.posibleWin = Config.currentStavka;
        }


    }
    public static void choiseSworm(ElemScripts elemPanel)
    {
        blockAllbuttons();
        for (int k = 0; k < 3; k++)
        {
            Config.allElemCastleList[k, Config.currentActiveStringCastlePlay].currentButtonImage.sprite = Config.stateCastlePlayList[2];
        }
        elemPanel.currentButtonImage.sprite = Config.stateCastlePlayList[0];

        Config.UIController.loseCastleGame();
        //StaticConfig.GridCastleScript.collectNow.gameObject.SetActive(false);


        //StaticConfig.loseWindowCastle.SetActive(true);
    }
}
