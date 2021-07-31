using System.Collections;
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

        Blue.Generar();
        Red.Generar();
        Green.Generar();
        Blue.Generar();
        Red.Generar();
        Blue.Generar();
        Green.Generar();
        Blue.Generar();

    }

    // Update is called once per frame
    void Update()
    {
        //int N = Random.Range(1,1000);

        //if (N >= 1 && N<=10)
        //{
        //    Generar_Red();
        //}
        //else if (N >= 11 && N <= 15)
        //{
        //    Generar_Blue();
        //}
        //else if (N >= 21 && N <= 25)
        //{
        //    Generar_Green();
        //}

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
