using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField]
    protected float speed, gold, life;
    public delegate void actionDelegate();
    public actionDelegate e_Death;

    protected abstract void Movement();
    
    public void ReceiveDamage(float damage)
    {
        life -= damage;
        if (life <= 0) {
            Killed();
        }
    }

    public void Death()
    {
        Destroy(gameObject);
        e_Death();
    }

    public void Killed()
    {
        Player.Instance.EarnReward(gold);
        Death();
    }



}
