using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [Header("������� ����")] public GameObject castleGame;
    public GameObject setUpOrderGame;
    public GameObject orderGame;

    [Header("������� ������� ����")] public GameObject winCastle;
    public GameObject loseCastle;
    public GameObject winORDER;
    public GameObject loseORDER;


    [Header("��������� ���� ����")] public GameObject Menu;

    [Header("������ CASTLE")] public Button plusStavkaCastle;
    public Button minusStavkaCastle;
    public Button playAgain; //-1
    public Button collectNow;
    public Button startCastle;

    [Header("����� CASTLE")] public Text valueStavkaCastle;
    public Text valueIfWinCastle;
    public Text WinGameValueTxt;


    [Header("������ SetUpORDER")] public List<Button> listLine;
    public Button plusStavkaORDER;
    public Button minusStavkaORDER;
    public Button StartGameORDER;

    [Header("����� SetUpORDER")] public Text valueStavkaORDER;
    public Text valueHaveCoinORDER;
    public Text valueIfWinORDER;


    [Header("Buy ������")] public GameObject buyCoins;
    public GameObject buyHearts;


    [Header("��������� ������")] public GridControllCastle GridControllCastle;

    [Header("���������� � �������")] public Text mainWindowCoins;
    public Text OrderSetUpCoins;
    public Text subl;

    [Header("���������� �  �������")] public Text mainWindowHearts;

    [Header("##############")] public bool haveHearth;
    public bool haveCoins;
    public GameObject whitePole;

    void Start()
    {
        Button[] allButtons = FindObjectsOfType<Button>(true);

        foreach (Button button in allButtons)
        {
            button.gameObject.GetComponent<Button>().onClick.AddListener(TestONClick);
        }
    }

    public void TestONClick()
    {
        Config.AudioSource.GetComponent<AudioSource>().Play();
    }

    public void goToMEnu()
    {
        castleGame.SetActive(false);
        setUpOrderGame.SetActive(false);
        orderGame.SetActive(false);
        winCastle.SetActive(false);
        loseCastle.SetActive(false);
        winORDER.SetActive(false);
        loseORDER.SetActive(false);

        Menu.SetActive(true);
    }

    public void needBuyCoins()
    {
        buyCoins.SetActive(true);
    }

    public void needBuyHearts()
    {
        buyHearts.SetActive(true);
    }

    #region CASTLE

    public void setUpCastle(bool freeVhod)
    {
        if (Config.currentStavka > Config.coins)
        {
            Config.currentStavka = Config.coins;
        }

        if (!ControllReserses.isPosibleChangeCoins(Config.currentStavka))
        {
            buyCoins.SetActive(true);
            return;
        }

        updateText();
        whitePole.SetActive(true);
        if (freeVhod)
        {
            startCastle.gameObject.SetActive(true);
            playAgain.gameObject.SetActive(false);
        }
        else
        {
            if (!ControllReserses.isPosibleChangeHearts(-1))
            {
                buyHearts.SetActive(true);
                return;
            }

            startCastle.gameObject.SetActive(true);
            playAgain.gameObject.SetActive(false);
            ControllReserses.changeHeartsValue(-1);
        }

        plusStavkaCastle.gameObject.SetActive(true);
        minusStavkaCastle.gameObject.SetActive(true);
        valueStavkaCastle.gameObject.SetActive(true);

        collectNow.gameObject.SetActive(false);
        valueIfWinCastle.gameObject.SetActive(false);

        winCastle.SetActive(false);
        loseCastle.SetActive(false);
    }

    public GameObject fonKastl;
    public void startGameCastle(bool isNeedToPay)
    {
        if (Config.currentStavka <= 0 || Config.currentStavka > Config.coins)
        {
            return;
        }

        fonKastl.GetComponent<ImageKost>().StartGame(fonKastl);
        Config.posibleWin = Config.currentStavka;
        updateText();
        if (!ControllReserses.isPosibleChangeCoins(Config.currentStavka))
        {
            buyCoins.SetActive(true);
            return;
        }

        if (isNeedToPay)
        {
            if (!ControllReserses.isPosibleChangeHearts(-1))
            {
                buyHearts.SetActive(true);
                return;
            }

            if (!ControllReserses.isPosibleChangeCoins(Config.currentStavka))
            {
                buyCoins.SetActive(true);
                return;
            }

            ControllReserses.changeHeartsValue(-1);


            //print(Config.coins);
            //print(Config.hearts);
        }


        ControllReserses.changeCoinsValue(-Config.currentStavka);

        whitePole.SetActive(false);
        collectNow.gameObject.SetActive(true);
        GridControllCastle.startGame();


        //collectNow.gameObject.SetActive(true);////!!!! ������ �����
        valueIfWinCastle.gameObject.SetActive(true);


        playAgain.gameObject.SetActive(false);
        startCastle.gameObject.SetActive(false);
        valueStavkaCastle.gameObject.SetActive(false);
        plusStavkaCastle.gameObject.SetActive(false);
        minusStavkaCastle.gameObject.SetActive(false);
        valueStavkaCastle.gameObject.SetActive(false);
    }

    public void collectCoins()
    {
        if (Config.currentActiveStringCastlePlay != 0)
        {
            winCastleGame();
        }
    }

    public void backAnim()
    {
        Config.gridAnimator.GetComponent<Animator>().SetBool("BackUp", true);
    }

    public void winCastleGame()
    {
        ControllReserses.changeCoinsValue(Config.posibleWin);


        updateText();
        winCastle.SetActive(true);

        Config.posibleWin = 0;

        if (Config.IsWonCastleGame == false)
        {
            Config.AchivmentsControll.upAchivka(1);
        }

        Config.IsWonCastleGame = true;
        Config.SaveGame();
    }


    public void loseCastleGame()
    {
        updateText();
        loseCastle.SetActive(true);
    }

    public void changeStavka(int i)
    {
        if (Config.currentStavka > Config.coins)
        {
            Config.currentStavka = Config.coins;
        }

        if (Config.currentStavka + (10 * i) < 0 || Config.currentStavka + (10 * i) > Config.coins)
        {
            return;
        }
        //if (ControllReserses.isPosibleChangeCoins(StaticConfig.currentStavka +(10*i), 1))
        //{

        //}
        Config.currentStavka += 10 * i;
        //print(Config.currentStavka + (10 * i));

        updateText();
    }

    public void changeStavka_2(int i)
    {
        if (Config.currentStavka > Config.coins)
        {
            Config.currentStavka = Config.coins;
        }

        if (Config.currentStavka + (10 * i) <= 0 || Config.currentStavka + (10 * i) > Config.coins)
        {
            return;
        }
        //if (ControllReserses.isPosibleChangeCoins(StaticConfig.currentStavka +(10*i), 1))
        //{

        //}
        Config.currentStavka += 10 * i;
        //print(Config.currentStavka + (10 * i));
        Config.posibleWin = 2 * (Config.diffictly + 1) * Config.currentStavka;
        updateText();
    }

    #endregion

    #region ORDER

    public void setUpORDERGame()
    {
        if (Config.currentStavka > Config.coins)
        {
            Config.currentStavka = Config.coins;
        }

        updateText();
        setUpOrderGame.SetActive(true);

        Menu.SetActive(false);
        orderGame.SetActive(false);
        loseORDER.SetActive(false);
        winORDER.SetActive(false);
    }

    public void startGameOrder()
    {
        if (Config.currentStavka <= 0)
        {
            return;
        }

        updateText();
        if (!ControllReserses.isPosibleChangeHearts(-1))
        {
            buyHearts.SetActive(true);
            return;
        }

        if (!ControllReserses.isPosibleChangeCoins(Config.currentStavka))
        {
            buyCoins.SetActive(true);
            return;
        }

        ControllReserses.changeHeartsValue(-1);
        ControllReserses.changeCoinsValue(-Config.currentStavka);
        Config.gridOrderScript.startGame(Config.diffictly + 1);
        Menu.SetActive(false);
        setUpOrderGame.SetActive(false);
        orderGame.SetActive(true);
    }


    public void loseORDEReGame()
    {
        loseORDER.SetActive(true);
    }

    public void winORDERGame()
    {
        ControllReserses.changeCoinsValue(Config.posibleWin);
        updateText();

        winORDER.SetActive(true);
        Config.posibleWin = 0;

        if (Config.IsWonOrderGame == false)
        {
            Config.AchivmentsControll.upAchivka(1);
        }

        Config.IsWonOrderGame = true;
        Config.SaveGame();
    }

    #endregion

    public void BuyCoin(int valueByuCoin)
    {
        ControllReserses.changeCoinsValue(valueByuCoin);
        Config.AchivmentsControll.upAchivka(2);
    }

    public void BuyHearth(int valueByuHearth)
    {
        ControllReserses.changeHeartsValue(valueByuHearth);
    }

    public void BuyFiveHearth()
    {
        if (ControllReserses.isPosibleChangeCoins(-100))
        {
            ControllReserses.changeCoinsValue(-100);
            ControllReserses.changeHeartsValue(5);
        }
    }

    public void updateText()
    {
        subl.text = "+ " + Config.posibleWin.ToString();
        valueIfWinCastle.text = Config.posibleWin.ToString();
        valueStavkaORDER.text = Config.currentStavka.ToString();


        valueStavkaCastle.text = Config.currentStavka.ToString();
        WinGameValueTxt.text = Config.posibleWin.ToString();
        valueIfWinORDER.text = Config.posibleWin.ToString();
        OrderSetUpCoins.text = "In stock " + Config.coins.ToString();

        mainWindowCoins.text = Config.coins.ToString();
        mainWindowHearts.text = Config.hearts.ToString();
        //print(Config.posibleWin+ " === posibleWin");
        //��������� ��������� ������ ������ ��� ������� ���� ������
        // ������
        // ���������� ����
        // �������� ���-�� �����
        // �������� ���-�� ������
        // ...
    }

    public void updateValueResurses()
    {
        mainWindowCoins.text = Config.coins.ToString();
        mainWindowHearts.text = Config.hearts.ToString();
    }
}