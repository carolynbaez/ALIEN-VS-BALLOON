﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloons_Maker : MonoBehaviour
{

    public  Maker_Red Red;
    public  Maker_Red Blue;
    public  Maker_Red Green;


    // Start is called before the first frame update
    void Start()
    {






        int N = Random.Range(1, 30);

        Blue.Generar();
        Red.Generar();
        Green.Generar();
        Red.Generar();
        Red.Generar();
        Green.Generar();
        Blue.Generar();
        Green.Generar();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Generar_Red()
    {
        Red.Generar();
    }

    public  void Generar_Blue()
    {
        Blue.Generar();
    }

    public  void Generar_Green()
    {
        Green.Generar();
    }

}
