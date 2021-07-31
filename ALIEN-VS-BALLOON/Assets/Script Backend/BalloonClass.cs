using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonClass : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    public float maxVelo;
    public float minVelo;
    public GameObject Balloons;

    public GameObject Balloon;

    //public int Velocidad;

    public float TiempoCreacion = 0.5f;

    public float RangoCreacion = 1f;

    public string Color;

    public float min;

    public float max;

    public float y;

    public float z;
    //private float Velocidad;

    public float GenerarVelocidad()
    {
        float Velocidad = Random.Range(maxVelo, minVelo);
        return Velocidad;
    }
}
