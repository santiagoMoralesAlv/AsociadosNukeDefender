using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public LayerMask layerMask;

    void Start()
    {

    }

    void Update()
    {

        // Generate a plane that intersects the transform's position with an upwards normal.
        Plane playerPlane = new Plane(Vector3.up, transform.position);

        RaycastHit hit;

        // Generate a ray from the cursor position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitdist = 0.0f;

        int layer_mask = 0;
        layer_mask = LayerMask.GetMask("PlaneUS");


        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag == "PlaneUS")
            {
                Vector3 targetPoint = ray.GetPoint(hitdist);

                targetPoint = new Vector3(targetPoint.x, 0.0f, targetPoint.z);


                //Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
                Quaternion targetRotation = Quaternion.LookRotation(targetPoint - new Vector3(transform.position.x, 0.0f, transform.position.z));

                // Smoothly rotate towards the target point.
                transform.rotation = Quaternion.Slerp(transform.rotation.normalized, targetRotation.normalized, 100 * Time.deltaTime);
                
            }

        }
    }
}

