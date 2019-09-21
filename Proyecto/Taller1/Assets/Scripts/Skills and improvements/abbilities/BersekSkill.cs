using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tienda;

public class BersekSkill : Skill
{
    [SerializeField]
    private float timeEffect, timeAction;
    

    override public void Active()
    {
        Player.Instance.gameObject.AddComponent<BersekDecorator>();
        Player.Instance.gameObject.GetComponent<BersekDecorator>().TimeEffect = timeEffect;
        Player.Instance.gameObject.GetComponent<BersekDecorator>().e_finishSkill = FinishSkill;
        inAction = true;

    }

    override public void UpgradeAbbility()
    {
        if (StoreManager.Instance.BuyItem(id, Player.Instance.Bank))
        {
            level += 1;
            switch (level)
            {
                case 1:
                    timeEffect = timeEffect * 1.5f;
                    coolDown = 5f;
                    break;

                case 2:
                    timeEffect = timeEffect * 2f;
                    coolDown = 8f;
                    break;

                case 3:
                    timeEffect = timeEffect * 3f;
                    coolDown = 12f;

                    break;
                default:
                    break;
            }
        }
        //mejorar cooldown y tiempo de efecto
        //Se aumenta segun la variable level (YA ESTA EN EL PADRE)
    }

    public void FinishSkill()
    {
        inAction = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (waitTime < coolDown)
        {
            waitTime += Time.deltaTime;
        }
        else
        {
            waitTime = coolDown;
        }
    }
}
