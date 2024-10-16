//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class GotoStaticClass : MonoBehaviour
//{
//    public List<Sprite> stateCastlePlayList = new List<Sprite>();
//    public List<Sprite> SweetsCastlePlayList = new List<Sprite>();
//    public List<float> percentList = new List<float>();

//    public float coins = 0;
//    public float hearts = 0;

//    public GameObject buyCoin;
//    public GameObject buyHearth;
//    public GameObject loseWindow;
//    public GameObject winWindowOrder;
//    public GameObject winWindowCastle;
//    public GridCastleScript GridCastleScript;
//    public Text[] mbWinTxt;
//    public AchivmentsControll AchivmentsControll;

//    public SaveLoadManager SaveLoadManager;
//    private void OnEnable()
//    {
//        StaticConfig.SaveLoadManager = SaveLoadManager;
        

//        StaticConfig.stateCastlePlayList = stateCastlePlayList.ToArray();
//        StaticConfig.SweetsCastlePlayList = SweetsCastlePlayList.ToArray();
//        StaticConfig.percentList = percentList.ToArray();



//        StaticConfig.currentOrderItem = null;
//        StaticConfig.buyCoin = buyCoin;
//        StaticConfig.buyHearth = buyHearth;
//        StaticConfig.loseWindowCastle = loseWindow;
//        StaticConfig.winWindowOrder = winWindowOrder;
//        StaticConfig.winWindowCastle = winWindowCastle;
//        StaticConfig.GridCastleScript = GridCastleScript;

//        StaticConfig.mbWinTxt = mbWinTxt;
//        StaticConfig.AchivmentsControll = AchivmentsControll;






//        //coins = SaveLoadManager.saveStatic.coins;
//        //hearts = SaveLoadManager.saveStatic.hearth;
        
//    }
//    public void Start()
//    {
//        StaticConfig.a1v = SaveLoadManager.saveStatic.a1v;
//        StaticConfig.a2v = SaveLoadManager.saveStatic.a2v;
//        StaticConfig.a3v = SaveLoadManager.saveStatic.a3v;
//        StaticConfig.a4v = SaveLoadManager.saveStatic.a4v;


//        StaticConfig.a1bool = SaveLoadManager.saveStatic.a1bool;
//        StaticConfig.a2bool = SaveLoadManager.saveStatic.a2bool;
//        StaticConfig.a3bool = SaveLoadManager.saveStatic.a3bool;
//        StaticConfig.a4bool = SaveLoadManager.saveStatic.a4bool;
//    }
//}
