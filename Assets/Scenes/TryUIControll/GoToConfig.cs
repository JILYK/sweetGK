using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToConfig : MonoBehaviour
{
    public UIController uIController;
    public List<Sprite> stateCastlePlayList = new List<Sprite>();
    public List<Sprite> SweetsCastlePlayList = new List<Sprite>();
    public List<float> percentList = new List<float>();
    public  Animator gridAnimator;
    public  AudioSource AudioSource;

    public AchivmentsControll AchivmentsControll;

    public  GridOrderScript gridOrderScript;
    // Start is called before the first frame update
    private void OnEnable ()
    {
        Config.LoadGame();
        Config.stateCastlePlayList = stateCastlePlayList.ToArray();
        Config.SweetsCastlePlayList = SweetsCastlePlayList.ToArray();
        Config.percentList = percentList.ToArray(); 
        Config.UIController = uIController;
        //Config.coins = 200;
        //Config.hearts = 10;

        Config.gridAnimator = gridAnimator;
        Config.gridOrderScript = gridOrderScript;
        Config.UIController.updateText();
        Config.UIController.updateText();


        Config.AudioSource = AudioSource;


        Config.AchivmentsControll = AchivmentsControll;

        



    }
}
