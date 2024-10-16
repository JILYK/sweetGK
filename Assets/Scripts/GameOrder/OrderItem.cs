using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class OrderItem : MonoBehaviour
{
    public int typeElement;
    public bool isIncognito;
    public Button butItem;
    public Image childrenMines;
    public Image childrenMask;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void getType(int value)
    {
        typeElement = value + 1;
        childrenMines.sprite = Config.SweetsCastlePlayList[typeElement];
    }
    public void clickElemOrder()
    {
        if (!isIncognito)
        {
            foreach (OrderItem elenYes in Config.yesListStatic)
            {
                elenYes.butItem.image.sprite = Config.stateCastlePlayList[0];
            }
            
            Config.currentOrderItem = this;
            butItem.image.sprite = Config.stateCastlePlayList[4];
            
        }
        else
        {
            try
            {
                if (typeElement != 0 && typeElement == Config.currentOrderItem.typeElement)
                {
                    Config.currentOrderItem.childrenMines.enabled = false;
                    Config.currentOrderItem.butItem.interactable = false;
                    Config.currentOrderItem.butItem.image.enabled = false;

                    childrenMask.enabled = false;
                    childrenMines.enabled = true;
                    butItem.image.sprite = Config.stateCastlePlayList[0];


                    Config.currentOrderItem = null;
                    Config.valueIncognitoElem--;
                    if (Config.valueIncognitoElem == 0)
                    {
                        Config.UIController.winORDERGame();
                    }
                }
                else
                {
                    Config.UIController.loseORDEReGame();
                }
            }
            catch (Exception e)
            {

            }
        }


    }
}
