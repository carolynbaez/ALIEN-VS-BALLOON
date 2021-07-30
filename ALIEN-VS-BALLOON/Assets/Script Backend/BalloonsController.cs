using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonsController : MonoBehaviour
{
    public GameObject Balloon;

    //Variable para modfificar la velocidad de los globos
    //public float Velocidad = 0.3f;
    public int Velo;
    

    // Start is called before the first frame update
    int Start()
    {
        int Velocity = Random.Range(2, 10);
        return Velocity;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Start() > 5)
        //{
        //    Velo = 10;
        //}
        //else
        //{
        //    Velo = 0;
        //}
        transform.position += transform.up * /*Start()*/Velo * Time.deltaTime;
        //if (transform.position.y > 200)
        //{
        //    DestroyImmediate(Balloon, true);
        //}
        
    }
}
