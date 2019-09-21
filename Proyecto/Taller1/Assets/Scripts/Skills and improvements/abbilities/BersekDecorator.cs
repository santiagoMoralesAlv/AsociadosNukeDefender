using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BersekDecorator : MonoBehaviour
{
    private float rate=0.03f;
    private float timeEffect;
    public delegate void actionDelegate();
    public actionDelegate e_finishSkill;

    public float Rate
    {
        get
        {
            return rate;
        }
        
    }

    public float TimeEffect
    {
        get
        {
            return timeEffect;
        }

        set
        {
            timeEffect = value;
        }
    }

    private void Update()
    {
        timeEffect -= Time.deltaTime;
        if (timeEffect <= 0) {
            FinishSkill();
        }
    }


    public void FinishSkill()
    {
        Destroy(this);
        e_finishSkill();
    }

}
