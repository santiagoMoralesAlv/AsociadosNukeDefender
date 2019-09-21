using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet_Spawner, bullet;
    [SerializeField]
    private float bullet_Impulse;
    [SerializeField]
    private float damage, velocityBullet, rateAOE;

    [SerializeField]
    private float fireSpeedNormal, fireSpeedMin;
    private float fireSpeedMod, rateClic = 1;

    private float counterAutoShoot;          //Contador de tiempo a disparo automatico

    public float Damage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }
    public float VelocityBullet
    {
        get
        {
            return velocityBullet;
        }

        set
        {
            velocityBullet = value;
        }
    }
    public float RateAOE
    {
        get
        {
            return rateAOE;
        }

        set
        {
            rateAOE = value;
        }
    }

    private void Start()
    {
        fireSpeedMod = fireSpeedNormal;
    }

    void Update()
    {
        if (counterAutoShoot > fireSpeedMin+fireSpeedMod)
        {
            MakeShoot();
            counterAutoShoot = 0;
        }
        else
        {
            counterAutoShoot += Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0))
        {
            rateClic += 1;
        }
    }

    void FixedUpdate()
    {
        UpdateSpeedMod();
    }

    public void UpdateSpeedMod() {
        if (this.GetComponent<BersekDecorator>() == null)
        {
            rateClic = Mathf.Lerp(rateClic, 1, Time.deltaTime * 0.5f); //Normaliza la tasa de disparo
            fireSpeedMod = fireSpeedNormal * (1 / rateClic); //Normaliza la tasa de disparo
        }
        else {
            fireSpeedMod = this.GetComponent<BersekDecorator>().Rate;
        }
    }
    
    public void MakeShoot()
    {
        GameObject Temporary_Bullet_Handler;
        Temporary_Bullet_Handler = Instantiate(bullet, bullet_Spawner.transform.position, bullet_Spawner.transform.rotation) as GameObject;

        Temporary_Bullet_Handler.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * bullet_Impulse, ForceMode.Impulse);
        Temporary_Bullet_Handler.GetComponent<Bullet>().SetImprovements(damage, velocityBullet, rateAOE);
    }
    
}