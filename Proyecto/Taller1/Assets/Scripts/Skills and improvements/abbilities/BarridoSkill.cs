using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tienda;

public class BarridoSkill : Skill
{
    [SerializeField]
    private float damage;

    public void Start()
    {
        level = 0;
    }

    override public void Active()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject enemy in enemies)
        {
            enemy.GetComponent<Enemy>().ReceiveDamage(damage);
        }
    }

    override public void UpgradeAbbility()
    {
        if (StoreManager.Instance.BuyItem(id, Player.Instance.Bank) && level < 3)

        {
            switch (level)
            {
                case 1:
                    damage = damage * 2;

                    break;

                case 2:
                    damage = damage * 2;
                    break;

                case 3:
                    damage = damage * 2;
                    break;
                default:
                    break;
            }
        }
        //mejorar el daño y el cooldown
        //Se aumenta segun la variable level (YA ESTA EN EL PADRE)
    }

    // Update is called once per frame
    void Update()
    {
        waitTime += Time.deltaTime;
    }
}
