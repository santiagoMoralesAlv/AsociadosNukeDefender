using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tienda;

public class BarreraSkill : Skill
{
    [SerializeField]
    private GameObject barreraOBJPreFab;
    [SerializeField]
    private float timeEffect, lives;



    override public void Active()
    {
        GameObject t_barrera = Instantiate(barreraOBJPreFab, new Vector3(0, 1.46f, -2.84f), Quaternion.identity);
        t_barrera.GetComponent<Barrera>().TimeEffect = timeEffect;
        t_barrera.GetComponent<Barrera>().Lives = lives;
    }

    override public void UpgradeAbbility()
    {
        if (StoreManager.Instance.BuyItem(id, Player.Instance.Bank) && level < 3)
        {
            level += 1;
            switch (level)
            {
                case 1:
                    timeEffect = timeEffect * 1.5f;
                    lives += 1;
                    break;

                case 2:
                    timeEffect = timeEffect * 1.5f;
                    lives += 2;
                    break;

                case 3:
                    timeEffect = timeEffect * 1.5f;
                    lives += 3;
                    break;
                default:
                    break;
            }
        }
        //mejorar el tiempo de efecto y las vidas
        //Se aumenta segun la variable level (YA ESTA EN EL PADRE)
    }

    // Update is called once per frame
    void Update()
    {
        waitTime += Time.deltaTime;
    }
}
