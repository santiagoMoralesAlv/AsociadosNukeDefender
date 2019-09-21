using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tienda;

[RequireComponent(typeof(Turret))]
public class Player : MonoBehaviour
{

    #region singleton
    private static Player instance;

    public static Player Instance
    {
        get
        {
            return instance;
        }

    }

    

    #endregion

    public delegate void action();
    public event action die; 
            
    private int lives;
    private BankPlayer bank;

    public int Lives
    {
        get
        {
            return lives;
        }
    }

    public BankPlayer Bank
    {
        get
        {
            return bank;
        }
    }

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        lives = 6;
        bank = new BankPlayer();
    }

    private void GetDamage() {

        if (lives == 0)
        {
            die();            
        }

        lives -= 1;
    }

    private int GetMaxScore()
    {
        return PlayerPrefs.GetInt("MaxScore", 0);
    }

    private void SaveScore(int scoreT)
    {
        PlayerPrefs.SetInt("MaxScore", scoreT);
    }

    private void ResetScore()
    {
        PlayerPrefs.SetInt("MaxScore", 0);
    }

    public void EarnReward(float reward)
    {
        if (this.GetComponent<BersekDecorator>() != null)
        {
            reward = reward * 3;
        }

        int typeCoin = Random.Range(0, 100);
        if (typeCoin < 85)
        {
            bank.ReceiveTransfer(reward, TypeCoins.A);
        }
        else
        {
            bank.ReceiveTransfer(reward, TypeCoins.B);
        }


        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            GetDamage();
            collision.gameObject.GetComponent<Enemy>().Death();

        }
    }
}
