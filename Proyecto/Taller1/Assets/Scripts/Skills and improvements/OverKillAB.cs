using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverKillAB : MonoBehaviour
{
    GameObject overKillOBJ;
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
                overKillOBJ.SetActive(true);
            }
            if (Counter <= 0)
            {
                overKillOBJ.SetActive(false);
                ActivarHabilidad = false;
            }
            Counter -= Time.deltaTime;
        }
        

    }
    void ABactive()
    {
        Counter = maxTime;
        ActivarHabilidad = true;
    }



}
