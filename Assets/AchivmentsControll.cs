using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivmentsControll : MonoBehaviour
{
    public Achivka[] AchivkaList;
    [System.Serializable]
    public struct Achivka
    {
        //public int maxValueSlider;
        public int currnetValueSlider;
        public Slider Slider;
        public bool isUses;
        public int valueCoins;
        public Button butActive;

        public Text text;
    }


    public DailyLoginRewards DailyLoginRewards;
    public void Start()
    {
        pizdec();
        updateUIAchivka();
    }
    public void clickAhivka(int nomerAchivka)
    {
        switch (nomerAchivka)
        {
            case 0:
                Config.a1bool = true;
                break;
            case 1:
                Config.a2bool = true;
                break;
            case 2:
                Config.a3bool = true;
                break;
            case 3:
                Config.a4bool = true;
                break;
            default:
                break;
        }
        AchivkaList[nomerAchivka].isUses = true;
        AchivkaList[nomerAchivka].butActive.gameObject.SetActive(false);
        ControllReserses.changeCoinsValue(AchivkaList[nomerAchivka].valueCoins);
        updateUIAchivka();
        Config.SaveGame();
    }
    public void pizdec()
    {
        AchivkaList[0].currnetValueSlider = Config.a1v;
        AchivkaList[1].currnetValueSlider = Config.a2v;
        AchivkaList[2].currnetValueSlider = Config.a3v;
        AchivkaList[3].currnetValueSlider = Config.a4v;

        AchivkaList[0].isUses = Config.a1bool;
        AchivkaList[1].isUses = Config.a2bool;
        AchivkaList[2].isUses = Config.a3bool;
        AchivkaList[3].isUses = Config.a4bool;
    }

    public void checkAchivkaTwo(bool isCastle, bool isOrder)
    {
        if (isCastle && isOrder) upAchivka(1);
    }
    public void upAchivka(int nomerAchivka)
    {
        if (AchivkaList[nomerAchivka].currnetValueSlider >= AchivkaList[nomerAchivka].Slider.maxValue)
        {
            return;
        }

        switch (nomerAchivka)
        {
            case 0:
                Config.a1v++;
                break;
            case 1:
                    Config.a2v++;
                break;
            case 2:
                    Config.a3v++;
                break;
            case 3:
                    Config.a4v++;
                break;
            default:
                break;
        }
        updateUIAchivka();


    }
    public void updateUIAchivka()
    {
        pizdec();
        for (int i = 0; i < 4; i++)
        {
            AchivkaList[i].text.text = AchivkaList[i].currnetValueSlider + "/" + AchivkaList[i].Slider.maxValue;

            AchivkaList[i].Slider.value = AchivkaList[i].currnetValueSlider;
            if (AchivkaList[i].isUses)
                AchivkaList[i].butActive.gameObject.SetActive(false);
            if (AchivkaList[i].currnetValueSlider == AchivkaList[i].Slider.maxValue && !AchivkaList[i].isUses)
            {
                AchivkaList[i].butActive.interactable = true;

                //print("Чтото нормальное чтобы мы понимали");
                //switch (i)
                //{
                //    case 0:
                //        Config.a1bool = true;
                //        print(Config.a1bool);
                //        break;
                //    case 1:
                //        Config.a2bool = true;
                //        print(Config.a2bool);
                //        break;
                //    case 2:
                //        Config.a3bool = true;
                //        print(Config.a3bool);
                //        break;
                //    case 3:
                //        Config.a4bool = true;
                //        print(Config.a4bool);
                //        break;
                //    default:
                //        break;
                //}

            }
        }

        Config.SaveGame();
    }

}


//using System.Collections;
//using System.Collections.Generic;
//using Unity.VisualScripting;
//using UnityEngine;
//using UnityEngine.UI;

//public class AchivmentsControll : MonoBehaviour
//{
//    public Achivka[] AchivkaList;
//    public SaveLoadManager SaveLoadManager;

//    [System.Serializable]
//    public struct Achivka
//    {
//        //public int maxValueSlider;
//        public int currnetValueSlider;
//        public Slider Slider;
//        public bool isUses;
//        public int valueCoins;
//        public Button butActive;

//        public Text text;
//    }


//    public void Start()
//    {
//        Config.achievements = AchivkaList;
//        updateUIAchivka();
//    }

//    public void loadAchivka(Save.AchievementStruct[] saveAchievments)
//    {
//        for (int i = 0; i < 4; i++)
//        {


//            AchivkaList[i].currnetValueSlider = saveAchievments[i].valueSlider;
//            AchivkaList[i].isUses = saveAchievments[i].isUses;
//        }
//        updateUIAchivka();
//    }

//    public void clickAhivka(int nomerAchivka)
//    {
//        AchivkaList[nomerAchivka].isUses = true;
//        AchivkaList[nomerAchivka].butActive.gameObject.SetActive(false);
//        ControllReserses.changeCoinsValue(AchivkaList[nomerAchivka].valueCoins);
//        Config.SaveLoadManager.saveGame();
//    }

//    public void checkAchivkaTwo(bool isCastle, bool isOrder)
//    {
//        if (isCastle && isOrder) upAchivka(1);
//    }

//    public void upAchivka(int nomerAchivka)
//    {
//        AchivkaList[nomerAchivka].currnetValueSlider++;
//        print("AchivkaList[nomerAchivka].currnetValueSlider++; " + AchivkaList[nomerAchivka].currnetValueSlider++);
//        updateUIAchivka();
//    }

//    public void updateUIAchivka()
//    {
//        for (int i = 0; i < 4; i++)
//        {
//            AchivkaList[i].text.text = AchivkaList[i].currnetValueSlider + "/" + AchivkaList[i].Slider.maxValue;

//            AchivkaList[i].Slider.value = AchivkaList[i].currnetValueSlider;
//            if (AchivkaList[i].isUses)
//                AchivkaList[i].butActive.gameObject.SetActive(false);
//            if (AchivkaList[i].currnetValueSlider == AchivkaList[i].Slider.maxValue && !AchivkaList[i].isUses)
//            {
//                AchivkaList[i].butActive.interactable = true;
//            }
//        }

//        Config.SaveLoadManager = SaveLoadManager;
//        print("SaveLoadManager" + Config.SaveLoadManager);

//        Config.SaveLoadManager.saveGame();
//    }
//}