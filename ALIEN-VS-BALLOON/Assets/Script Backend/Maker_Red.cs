using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maker_Red : MonoBehaviour /*BalloonClass*/
{
    //BalloonClass Balloon = new BalloonClass();
    public GameObject Balloons;

    GameObject Balloon;

    //public int Velocidad;

    public float TiempoCreacion = 0.5f;

    public float RangoCreacion = 1f;

    public string Color;

    public float min;

    public float max;

    public float y;

    public float z;

    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    public void Generar()
    {
        InvokeRepeating("Create_Red", 0.0f, TiempoCreacion);
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void Create_Red()
    {
       


        //Generador de números aleatorios
        float XRandom = Random.Range(min, max);


        Vector3 SpawPosition; ;


        SpawPosition = new Vector3(XRandom, y, z);

        Balloon =  Instantiate(Balloons, SpawPosition, Quaternion.identity);
        
    }

}
