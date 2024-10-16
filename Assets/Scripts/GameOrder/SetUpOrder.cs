using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetUpOrder : MonoBehaviour
{
    public GridOrderScript GridOrderScript;
    public Text valueStavka;
    public Text mbValue;
    public List<Button> allButtonDifficulty;

    [SerializeField] private Text StavkaTxt;
    int difficulty = 1;
    private void Start()
    {
        
    }
    public void selectDifficulty(int nomberBut)
    {
        foreach(Button but in allButtonDifficulty)
        {
            but.image.enabled = true;
        }
        allButtonDifficulty[nomberBut].image.enabled = false;
        difficulty = nomberBut;
        Config.diffictly = nomberBut;

        Config.posibleWin = 2 * (difficulty + 1) * Config.currentStavka;
        Config.UIController.updateText();
    }
    public void startGame()
    {
        GridOrderScript.startGame(difficulty+1);
    }

    public void changeStavka(int valueStavka)
    {
        if (valueStavka < 0 && StaticConfig.currentStavka < Mathf.Abs(valueStavka))
        {
            return;
        }
        StaticConfig.currentStavka += valueStavka;
        updateStavka();
    }
    public void updateStavka()
    {
        StaticConfig.nbWin = 2 * (difficulty + 1)* StaticConfig.currentStavka;
        StavkaTxt.text = StaticConfig.currentStavka.ToString();
        mbValue.text = StaticConfig.nbWin.ToString();
    }

}
