using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FodderPlus : Enemy
{
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
    }
}
