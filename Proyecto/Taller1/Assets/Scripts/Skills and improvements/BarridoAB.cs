using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarridoAB : MonoBehaviour
{
    GameObject BarridoOBJ;
    public bool ActivarHabilidad;

    float maxTime;
    float Counter;
    void Start()
    {
        
    }

    void Update()
    {
        if (ActivarHabilidad) { 

            if (Counter > 0)
            {
                BarridoOBJ.SetActive(true);
            }
            if (Counter <= 0)
            {
                BarridoOBJ.SetActive(false);
                ActivarHabilidad = false;
            }
            Counter -= Time.deltaTime;
        }
        

    }
    void ABactive()
    {
        ActivarHabilidad = true;
    }



}
