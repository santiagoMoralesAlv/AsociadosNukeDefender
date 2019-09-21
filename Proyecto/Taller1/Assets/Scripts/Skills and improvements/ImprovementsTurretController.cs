using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Tienda;

public class ImprovementsTurretController : MonoBehaviour
{
    [SerializeField]
    private int levelDamage, levelAOE, levelVelocity;


    public void UpgradeDamage()
    {
        if (StoreManager.Instance.BuyItem("M001", Player.Instance.Bank) && levelDamage<3)
        {
            levelDamage += 1;
            switch (levelDamage)
            {
                case 1:
                    Player.Instance.gameObject.GetComponent<Turret>().Damage += 10;
                    break;
                case 2:
                    Player.Instance.gameObject.GetComponent<Turret>().Damage += 10;
                    break;
                case 3:
                    Player.Instance.gameObject.GetComponent<Turret>().Damage += 10;
                    break;
            }
        }
    }

    public void UpgradeAOE()
    {
        if (StoreManager.Instance.BuyItem("M002", Player.Instance.Bank) && levelAOE < 3)
        {
            levelAOE += 1;
            switch (levelAOE)
            {
                case 1:
                    Player.Instance.gameObject.GetComponent<Turret>().RateAOE += 10;
                    break;
                case 2:
                    Player.Instance.gameObject.GetComponent<Turret>().RateAOE += 10;
                    break;
                case 3:
                    Player.Instance.gameObject.GetComponent<Turret>().RateAOE += 10;
                    break;
            }
        }
    }

    public void UpgradeVelocity()
    {
        if (StoreManager.Instance.BuyItem("M003", Player.Instance.Bank) && levelVelocity < 3)
        {
            levelVelocity += 1;
            switch (levelVelocity)
            {
                case 1:
                    Player.Instance.gameObject.GetComponent<Turret>().VelocityBullet += 1;
                    break;
                case 2:
                    Player.Instance.gameObject.GetComponent<Turret>().VelocityBullet += 1;
                    break;
                case 3:
                    Player.Instance.gameObject.GetComponent<Turret>().VelocityBullet += 1;
                    break;
            }
        }
    }
}
