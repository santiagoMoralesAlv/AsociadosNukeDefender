using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverKillZone : MonoBehaviour
{
    private float timeEffect;
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

    private void Update()
    {
        timeEffect -= Time.deltaTime;

        if (timeEffect <= 0)
        {
            FinishSkill();
        }
    }

    public void FinishSkill()
    {
        Destroy(gameObject);
        e_finishSkill();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy")) {
            other.gameObject.GetComponent<Enemy>().Killed();
        }
    }


}
