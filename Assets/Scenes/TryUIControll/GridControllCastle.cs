using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridControllCastle : MonoBehaviour
{
    [SerializeField] private GameObject grid;
    [SerializeField] private Button elemGrid;
    [SerializeField] private ElemScripts[,] allElemList_1 = new ElemScripts[3, 6];
    private int typeElemGrid;
    private Button currentElemGrid;
    public void startGame()
    {
        Config.allElemCastleList = null;
        Config.currentActiveStringCastlePlay = 0;
        while (grid.transform.childCount > 0)
        {
            DestroyImmediate(grid.transform.GetChild(0).gameObject);
        }

        for (int i = 0; i < 6; i++)
        {

            for (int k = 0; k < 3; k++)
            {
                currentElemGrid = Instantiate(elemGrid, grid.transform);
                currentElemGrid.GetComponent<ElemScripts>().nomberElem = new Vector2Int(k, i);
                allElemList_1[k, i] = currentElemGrid.GetComponent<ElemScripts>();
                allElemList_1[k, i].getType(1);
                allElemList_1[k, i].currentPercent.text = "x" + Config.percentList[i];
            }
            typeElemGrid = Random.Range(0, 3);
            allElemList_1[typeElemGrid, i].getType(0);
        }
        Config.allElemCastleList = allElemList_1;
        ControllCastlePlay.nextString();
    }
    public void EndGame()
    {
        
    }
    public void newCastleGame()
    {
        //Config.posibleWin = Config.currentStavka;

        //ControllReserses.updateMbWin();
       
    }


}
