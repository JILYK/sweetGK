using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllSettings : MonoBehaviour
{
    public Sprite EnableStar;
    public Sprite DisableStar;
    public List<Button> allStar;

    private void Start()
    {
        if (Config.starRating != -1)
        {
            for (int i = 0; i < 5; i++) allStar[i].GetComponent<Image>().sprite = DisableStar;
            for (int i = 0; i <= Config.starRating; i++) allStar[i].GetComponent<Image>().sprite = EnableStar;
        }
    }

    public void starClick(int nomberClick)
    {
        for (int i = 0; i < 5; i++) allStar[i].GetComponent<Image>().sprite = DisableStar;
        for (int i = 0; i <= nomberClick; i++) allStar[i].GetComponent<Image>().sprite = EnableStar;

        Config.AchivmentsControll.upAchivka(3);
        Config.starRating = nomberClick;
        Config.SaveGame();
    }
}