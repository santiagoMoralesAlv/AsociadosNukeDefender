using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Tienda;

public class ShowDataHUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI LevelHud;
    [SerializeField] TextMeshProUGUI ScrewCoin_Hud;
    [SerializeField] TextMeshProUGUI BookCoin_Hud; 
    
    [SerializeField]
    private GameObject losePanelOBJ;

    //Pasivas
    [SerializeField] private TextMeshProUGUI damage;

    #region singleton
    private static ShowDataHUD instance;

    public static ShowDataHUD Instance
    {
        get
        {
            return instance;
        }
        
    }

    #endregion
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else {
            Destroy(this);
        }    
    }

    public void Start()
    {
        losePanelOBJ.SetActive(false);
        Player.Instance.die += LoseGame;
    }

    private void Update()
    {
        UpdateCoins();

    }

    public void UpdateLevel() {

        LevelHud.text = CoreGame.Instance.ActualLevel.ToString();    
    }

    public void UpdateCoins()
    {
        ScrewCoin_Hud.text = "Screw " + ParseCoins(Player.Instance.Bank.CreditsA);
        BookCoin_Hud.text = "Book " + ParseCoins(Player.Instance.Bank.CreditsB);
    }

    private string ParseCoins(float value)
    {
        string t_value = "";
        if (value > 999 && value < 999999)//miles
        {
            t_value = value / 1000 + " K";
        }
        else if (value >= 1000000 && value < 999999999)//millon
        {
            t_value = value / 100000 + " M";
        }
        else if (value >= 1000000000 && value < 999999999999)//billon
        {
            t_value = value / 10000000 + " MM";
        }
        else if (value >= 1000000000000 && value < 1000000000000000000)
        {
            t_value = value / 1000000000 + " B";
        }
        else if (value >= 1000000000000000)
        {
            t_value = value / 100000000000 + " BB";
            
        }

        return t_value;
    }

    public void LoseGame() {
        losePanelOBJ.SetActive(true);
    }


    private void UpdatePrices()
    {
        //damage.text = "" + StoreManager.Instance.GetPriceA;
    }
}
