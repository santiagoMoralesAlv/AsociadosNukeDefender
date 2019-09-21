using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float damage, velocity, rateAOE;
    private Rigidbody rb;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    public void Update()
    {
        Movement();
    }

    public void SetImprovements(float t_damage, float t_velocity, float t_rateAOE)
    {
        damage = t_damage;
        velocity = t_velocity;
        rateAOE = t_rateAOE;
    }

    private void Movement() {

        rb.AddRelativeForce(Vector3.forward * velocity, ForceMode.Force);
    }

    private void OnCollisionEnter (Collision collision)
    {
        
        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<Enemy>().ReceiveDamage(damage);
            Explosion();
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
    

    public void Explosion()
    {
        //ACA SE INVOCA LA EXPLOCION
    }
    
}
