using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Balloons_Maker : MonoBehaviour
{

    public /*static*/ Maker_Red Red;
    public /*static*/ Maker_Red Blue;
    public /*static*/ Maker_Red Green;
    //public Maker_Green Green;
    //public Maker_Blue Blue;

    // Start is called before the first frame update
    void Start()
    {
        //Creando hilos
        //Thread Rojo = new Thread(Generar_Red);
        //Thread Blue = new Thread(Generar_Blue);
        //Thread Green = new Thread(Generar_Green);

        //Rojo.Start();
        //Blue.Start();
        //Green.Start();





        int N = Random.Range(1, 30);

        //if (N >= 1 && N <= 10)
        //{
        //    Red.Generar();
        //    Debug.Log(N);
        //}
        //else if (N >= 11 && N <= 20)
        //{
        //    Blue.Generar();
        //    Debug.Log(N);
        //}
        //else if (N >= 21 && N <= 30)
        //{
        //    Green.Generar();
        //    Debug.Log(N);
        //}
        //else
        //{
        //    Blue.Generar();
        //    Debug.Log(N);
        //}
        Blue.Generar();
        Red.Generar();
        Green.Generar();
        Red.Generar();
        Red.Generar();
        Green.Generar();
        Blue.Generar();
        Green.Generar();

        //Blue.Generar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public /*static*/ void Generar_Red()
    {
        Red.Generar();
    }

    public /*static*/ void Generar_Blue()
    {
        Blue.Generar();
    }

    public /*static*/ void Generar_Green()
    {
        Green.Generar();
    }

}
