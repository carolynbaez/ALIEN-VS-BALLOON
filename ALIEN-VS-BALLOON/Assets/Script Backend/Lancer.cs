using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lancer : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject lacer;
    public float fuegoRango = 0.5f;
    float TiempoFuego = 0.5f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Time.time > TiempoFuego) 
        {
            TiempoFuego = Time.time + fuegoRango;
            fuego();
        }
    }

    private void fuego()
    {
        Instantiate(lacer, transform.position, Quaternion.identity);
    }
}
