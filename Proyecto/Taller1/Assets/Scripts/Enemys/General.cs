using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General : Enemy
{
    [SerializeField]
    private float direction;
    private Rigidbody rb;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Movement();
    }

    protected override void Movement()
    {
        rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Force);

        rb.AddRelativeForce(Vector3.right * speed * direction, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            direction = direction * -1;
        }
    }

}
