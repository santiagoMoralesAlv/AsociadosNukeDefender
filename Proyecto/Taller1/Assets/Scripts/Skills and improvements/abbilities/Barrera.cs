using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrera : MonoBehaviour
{
    private float timeEffect;
    private float lives;

    public delegate void actionDelegate();
    public actionDelegate e_finishSkill;

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

    public float Lives
    {
        get
        {
            return lives;
        }

        set
        {
            lives = value;
        }
    }

    public void GetDamage() {
        lives -= 1;
        if (lives == 0) {
            FinishSkill();
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
        Destroy(gameObject);
        e_finishSkill();
    }
}
