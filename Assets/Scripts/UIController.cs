using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController: MonoBehaviour
{
    [SerializeField] private SettingsPopUp settingsPopup;
    private Image publicityLevelDisplay;
    private Image legalLevelDisplay;
    private Image researchLevelDisplay;
    private int owner;
    // private int price = 100;
    static uint count = 2;

    void Start()
    {
        settingsPopup.Close();
    }

    public void OnOpenSettings()
    {
        //Debug.Log("Opened");

        if (count % 2 == 0)
        {
            settingsPopup.Open();
            Debug.Log(count);
        }

        else
        {
            settingsPopup.Close();
            Debug.Log(count);
        }

        count++;
    }

    public void closePopUp()
    {
        settingsPopup.Close();
        count = 2;
    }

    public void incrementPublicity()
    {
        if (MasterControl.control.currGame.players[owner].publicity > 10)
        {
            //Error Popup (Can't exceed 10 [as of now])
            return;
        }

        owner = MasterControl.control.currGame.currentPlayer;
        MasterControl.control.currGame.players[owner].publicity++;
        // Debug.Log(MasterControl.control.currGame.players[owner].publicity);
        Debug.Log(owner);
    }

    public void incrementLegal()
    {
        if (MasterControl.control.currGame.players[owner].lawyers > 10)
        {
            //Error Popup (Can't exceed 10 [as of now])
            return;
        }

        owner = MasterControl.control.currGame.currentPlayer;
        MasterControl.control.currGame.players[owner].lawyers++;
    }

    public void incrementResearch()
    {
        if (MasterControl.control.currGame.players[owner].research > 10)
        {
            //Error Popup (Can't exceed 10 [as of now])
            return;
        }

        owner = MasterControl.control.currGame.currentPlayer;
        MasterControl.control.currGame.players[owner].research++;
    }
    /*
    public void displayLevelPrice()
    {
        owner = MasterControl.control.currGame.currentPlayer;
        Text text1 = GameObject.FindGameObjectsWithTag("Price")[0].GetComponent<Text>();
        text1.text = "";

        if (MasterControl.control.currGame.players[owner].publicity == 0)
            text1.text = "Invest " + price;

        else if (MasterControl.control.currGame.players[owner].publicity == 1)
            text1.text = "Invest " + price*5;

        else if (MasterControl.control.currGame.players[owner].publicity == 2)
            text1.text = "Invest " + price*10;

        else if (MasterControl.control.currGame.players[owner].publicity == 3)
            text1.text = "Invest " + price*15;

        else if (MasterControl.control.currGame.players[owner].publicity == 4)
            text1.text = "Invest " + price*20;

        else if (MasterControl.control.currGame.players[owner].publicity == 5)
            text1.text = "Invest " + price*25;

        else if (MasterControl.control.currGame.players[owner].publicity == 6)
            text1.text = "Invest " + price*30;

        else if (MasterControl.control.currGame.players[owner].publicity == 7)
            text1.text = "Invest " + price*35;

        else if (MasterControl.control.currGame.players[owner].publicity == 8)
            text1.text = "Invest " + price*40;

        else if (MasterControl.control.currGame.players[owner].publicity == 9)
            text1.text = "Invest " + price*45;

        else if (MasterControl.control.currGame.players[owner].publicity == 10)
            text1.text = "Invest " + price*50;

    }
    */
}