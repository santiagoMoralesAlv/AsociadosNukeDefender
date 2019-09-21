using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilitiesControllerUI : MonoBehaviour
{

    [Header("GameObjects")]
    public GameObject AB1_OBJ;
    public GameObject AB2_OBJ;
    public GameObject AB3_OBJ;

    [Header("Ability 1 BTN")]
    public Button ab1BTN;
    public Button improveAB1;
    public Button useAB1;
    private bool usingAB1;
    public GameObject cantidadDineroAB1;
    public GameObject CooldownAB1;
    public GameObject DurationAB1;



    [Header("Ability 2 BTN")]
    public Button ab2BTN;
    public Button improveAB2;
    public Button useAB2;
    private bool usingAB2;
    public GameObject cantidadDineroAB2;
    public GameObject CooldownAB2;
    public GameObject DurationAB2;


    [Header("Ability 3 BTN")]
    public Button ab3BTN;
    public Button improveAB3;
    public Button useAB3;
    private bool usingAB3;
    public GameObject cantidadDineroAB3;
    public GameObject CooldownAB3;
    public GameObject DurationAB3;
    






    // Start is called before the first frame update
    void Start()
    {
        ab1BTN.onClick.AddListener(Ab1Pressed);
        ab2BTN.onClick.AddListener(Ab2Pressed);
        ab3BTN.onClick.AddListener(Ab3Pressed);

    }

    // Update is called once per frame
    void Update()
    {
        if (usingAB1)
        {
            CooldownAB1.SetActive(true);
            cantidadDineroAB1.SetActive(false);
            DurationAB1.SetActive(false);
        }
        else
        {
            CooldownAB1.SetActive(false);
            cantidadDineroAB1.SetActive(true);
            DurationAB1.SetActive(true);
        }
        if (usingAB2)
        {
            CooldownAB2.SetActive(true);
            cantidadDineroAB2.SetActive(false);
            DurationAB2.SetActive(false);
        }
        else
        {
            CooldownAB2.SetActive(false);
            cantidadDineroAB2.SetActive(true);
            DurationAB2.SetActive(true);
        }
        if (usingAB3)
        {
            CooldownAB3.SetActive(true);
            cantidadDineroAB3.SetActive(false);
            DurationAB3.SetActive(false);
        }
        else
        {
            CooldownAB3.SetActive(false);
            cantidadDineroAB3.SetActive(true);
            DurationAB3.SetActive(true);
        }
    }

    void Ab1Pressed()   
    {
        AB1_OBJ.SetActive(true);
        AB2_OBJ.SetActive(false);
        AB3_OBJ.SetActive(false);
    }
    void Ab2Pressed()
    {
        AB2_OBJ.SetActive(true);
        AB1_OBJ.SetActive(false);
        AB3_OBJ.SetActive(false);
    }
    void Ab3Pressed()
    {
        AB3_OBJ.SetActive(true);
        AB1_OBJ.SetActive(false);
        AB2_OBJ.SetActive(false);   
    }
}
