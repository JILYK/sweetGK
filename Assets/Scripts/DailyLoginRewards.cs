// ADD TO NIKITA

using System;
using UnityEngine;
using UnityEngine.UI;

public class DailyLoginRewards : MonoBehaviour
{
    public Text currentStreakText;

    public Text TaskText;
    public GameObject TaskSlider;

    public GameObject currentStreakSlider;
    public GameObject takeButton;
    public GameObject viewButton;
    public Text rewardText;

    public AchivmentsControll AchivmentsControll;

    private void OnEnable()
    {
        LoadLoginDate();
        CheckDailyLogin();
        UpdateLayout();
    }

    private void LoadLoginDate()
    {
        // Загрузка последней даты входа и текущей последовательности из PlayerPrefs
        if (string.IsNullOrEmpty(Config.lastLogin))
        {
            ResetStreak();
            Config.lastLogin = DateTime.Now.ToString();
        }
    }

    public void UpdateLayout()
    {
        if (Config.currentStreak > 7)
        {
            Config.currentStreak = 7;
        }

        currentStreakSlider.GetComponent<Slider>().value = Config.currentStreak;
        currentStreakText.text = "Day " + Config.currentStreak + "/7";

        if (Config.a1bool == false)
        {
            AchivmentsControll.AchivkaList[0].currnetValueSlider = Config.currentStreak;
            AchivmentsControll.AchivkaList[0].text.text = Config.currentStreak + "/7";
            Config.a1v = Config.currentStreak;
            AchivmentsControll.updateUIAchivka();
        }

        //currentStreakTextBG.text = Config.currentStreak % 7 + "/7";
        //currentStreakTextBGAll.text = Config.currentStreak + " days";
    }

    private void CheckDailyLogin()
    {
        DateTime currentLoginDate = DateTime.Now;
        DateTime lastLoginDate = DateTime.Parse(Config.lastLogin);

        TimeSpan timeDifference = currentLoginDate.Subtract(lastLoginDate);

        if (timeDifference.Days == 0 && Config.isRewardGot)
        {
            // Игрок уже заходил в игру сегодня
            ChangeButton();
            return;
        }
        else if (timeDifference.Days == 1)
        {
            // Игрок заходит в игру на следующий день, увеличиваем стик
            Config.isRewardGot = false;
            Config.currentStreak++;

            if (Config.currentStreak <= 7)
            {
                Config.a1v = Config.currentStreak;
                Config.AchivmentsControll.AchivkaList[0].currnetValueSlider = Config.currentStreak;
            }
        }
        else
        {
            // Прошло больше одного дня, сбрасываем стик
            Config.isRewardGot = false;
            ResetStreak();
        }

        // Сохраняем дату последнего входа и текущую последовательность
        Config.lastLogin = currentLoginDate.ToString();
        Config.SaveGame();
    }

    private void ResetStreak()
    {
        Config.currentStreak = 1;
        Config.SaveGame();
    }

    private void ChangeButton()
    {
        takeButton.SetActive(false);
        viewButton.SetActive(true);
    }

    public void GiveReward()
    {
        if (!Config.isRewardGot)
        {
            int rewardAmount = 50;
            ControllReserses.changeCoinsValue(rewardAmount);
            Config.isRewardGot = true;
            ChangeButton();
        }

        Config.SaveGame();
    }
}