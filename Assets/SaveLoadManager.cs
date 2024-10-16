////using System.Collections;
////using System.Collections.Generic;
////using UnityEngine;
////using System.IO;
////using System.Runtime.Serialization.Formatters.Binary;

////public class SaveLoadManager : MonoBehaviour
////{
////    string filePath;
////    public static Save saveStatic;

////    private void OnEnable()
////    {
////        filePath = Application.persistentDataPath + "/save.gamesave";
////        loadGame();
////    }
////    public void Start()
////    {

////    }
////    public void saveGame()
////    {
////        BinaryFormatter bf = new BinaryFormatter();
////        FileStream fs = new FileStream(filePath, FileMode.Create);

////        Save s = new Save();
////        s.saveProperty(StaticConfig.coins, StaticConfig.hearts, StaticConfig.a1v, StaticConfig.a2v, StaticConfig.a3v, StaticConfig.a4v, StaticConfig.a1bool, StaticConfig.a2bool, StaticConfig.a3bool, StaticConfig.a4bool);
////        bf.Serialize(fs, s);
////        fs.Close();
////    }
////    public void loadGame()
////    {
////        if (!File.Exists(filePath)) return;

////        BinaryFormatter bf = new BinaryFormatter();
////        FileStream fs = new FileStream(filePath, FileMode.Open);


////        saveStatic = (Save)bf.Deserialize(fs);
////        fs.Close();
////        StaticConfig.coins = saveStatic.coins;
////        StaticConfig.hearts = saveStatic.hearth;
////        StaticConfig.a1v = saveStatic.a1v;
////        StaticConfig.a2v = saveStatic.a2v;
////        StaticConfig.a3v = saveStatic.a3v;  
////        StaticConfig.a4v = saveStatic.a4v;
////        StaticConfig.a1bool = saveStatic.a1bool;
////        StaticConfig.a2bool = saveStatic.a2bool;
////        StaticConfig.a3bool = saveStatic.a3bool;
////        StaticConfig.a4bool = saveStatic.a4bool;
////    }
////}


////[System.Serializable]
////public class Save
////{
////    public float coins;
////    public float hearth;
////    public int a1v;
////    public int a2v;
////    public int a3v;
////    public int a4v;

////    public bool a1bool;
////    public bool a2bool;
////    public bool a3bool;
////    public bool a4bool;

////    public void saveProperty(float coins, float hearth, int a1v, int a2v, int a3v, int a4v, bool a1bool, bool a2bool, bool a3bool, bool a4bool)
////    {
////        this.coins = coins;
////        this.hearth = hearth;


////        this.a1v = a1v;
////        this.a2v = a2v;
////        this.a3v = a3v;
////        this.a4v = a4v;

////        this.a1bool = a1bool;
////        this.a2bool = a2bool;
////        this.a3bool = a3bool;
////        this.a4bool = a4bool;
////    }
////}


//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;

//public class SaveLoadManager : MonoBehaviour
//{
//    string filePath;
//    public static Save save;
//    public GameObject TaskBG;

//    private void OnEnable()
//    {
//        filePath = Application.persistentDataPath + "/save.gamesave";
//        loadGame();

//    }

//    public void saveGame()
//    {
//        //BinaryFormatter bf = new BinaryFormatter();
//        //FileStream fs = new FileStream(filePath, FileMode.Create);

//        //Save save = new Save();

//        ////print("Config.achievements   " + Config.achievements);

//        //save.SaveAchievements(Config.achievements);
//        //save.coins = Config.coins;
//        //save.hearts = Config.hearts;
//        //save.lastLogin = Config.lastLogin;
//        //save.currentStreak = Config.currentStreak;
//        //save.isRewardGot = Config.isRewardGot;

        

//        //bf.Serialize(fs, save);
//        //fs.Close();



//        PlayerPrefs.GetFloat("ValueCoin");
//    }

//    public void loadGame()
//    {
//        //if (!File.Exists(filePath)) return;

//        //BinaryFormatter bf = new BinaryFormatter();
//        //FileStream fs = new FileStream(filePath, FileMode.Open);


//        //save = (Save)bf.Deserialize(fs);
//        //fs.Close();

//        //Config.currentStreak = save.currentStreak;
//        //Config.isRewardGot = save.isRewardGot;
//        //Config.lastLogin = save.lastLogin;

//        //Config.coins = save.coins;
//        //Config.hearts = save.hearts;

//        //print("arr " + save.achievements);
//        //TaskBG.GetComponent<AchivmentsControll>().loadAchivka(save.achievements);
//    }
//}


//[System.Serializable]
//public class Save
//{
//    public AchievementStruct[] achievements = new AchievementStruct[4];

//    public float coins;
//    public int hearts;

//    public string lastLogin;
//    public int currentStreak;
//    public bool isRewardGot;

//    [System.Serializable]
//    public struct AchievementStruct
//    {
//        public int valueSlider;
//        public bool isUses;

//        public AchievementStruct(int valueSlider, bool isUses)
//        {
//            this.valueSlider = valueSlider;
//            this.isUses = isUses;
//        }
//    }

//    public void SaveAchievements(AchivmentsControll.Achivka[] achievements)
//    {
//        for (int i = 0; i < achievements.Length; i++)
//        {
//            this.achievements[i] = new AchievementStruct(achievements[i].currnetValueSlider, achievements[i].isUses);
//        }
//    }
//}