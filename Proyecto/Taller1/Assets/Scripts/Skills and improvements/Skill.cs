using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tienda;

public struct Price {
    float priceScrew;
    float priceBook;

    public Price(float priceA, float priceB) {
        priceScrew = priceA;
        priceBook = priceB;
    }
}

public abstract class Skill : MonoBehaviour
{
    protected string id;
    protected float coolDown, waitTime;
    protected bool inAction;
    protected int level;

    public float CoolDown
    {
        get
        {
            return coolDown;
        }
    }
    public float WaitTime
    {
        get
        {
            return waitTime;
        }
    }
    public bool InAction
    {
        get
        {
            return inAction;
        }
    }
    public int Level
    {
        get
        {
            return level;
        }
    }

    public bool isOutCoolDown()
    {
        bool result = false;

        if (waitTime >= coolDown)
        {
            result = true;
        }

        return result;
    }

    public bool isActive()
    {
        return inAction;
    }

    public bool CanPurchase()
    {
        bool result = false;

        if (StoreManager.Instance.CanPurchaseItem(id, Player.Instance.Bank))
        {
            result = true;
        }

        return result;
    }

    public Price GetPrice()
    {
        StoreItem t_item = StoreManager.Instance.GetItem(id);
        Price result = new Price(t_item.PriceCoinsA, t_item.PriceCoinsB);

        return result;
    }

    public bool CanUpgradeAbbility()
    {
        bool result = false;

        if (level < 3)
        {

        }

        return result;
    }

    public abstract void Active();

    public abstract void UpgradeAbbility();
    
}
