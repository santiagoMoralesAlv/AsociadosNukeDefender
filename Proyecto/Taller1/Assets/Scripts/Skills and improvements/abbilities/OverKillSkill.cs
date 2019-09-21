using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverKillSkill : Skill
{
    [SerializeField]
    private float timeEffect, timeAction;
    [SerializeField]
    private GameObject overKillOBJ;

    

    override public void Active()
    {
        GameObject t_barrera = Instantiate(overKillOBJ, new Vector3(7.5f, 3.42f, 2.13f), Quaternion.identity);
        t_barrera.GetComponent<OverKillZone>().TimeEffect = timeEffect;
        t_barrera.GetComponent<OverKillZone>().e_finishSkill += FinishSkill;
        inAction = true;
    }

    override public void UpgradeAbbility()
    {
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
