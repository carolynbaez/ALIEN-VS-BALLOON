using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonsController : MonoBehaviour
{
    //public GameObject Balloon;

    //Variable para modfificar la velocidad de los globos
    //public float Velocidad = 0.3f;
     
    public int min;
    public int max;
    public float limite;

    bool Call = true;
    int Velo;


    // Start is called before the first frame update
    //int Start()
    //{
    //    int Velocity = Random.Range(2, 10);
    //    return Velocity;
    //}

    // Update is called once per frame
    void Update()
    {
        if (Call == true)
        {
            Velo = Random.Range(min, max);
            Call = false;

        }

        transform.position += transform.up * Velo * Time.deltaTime;

        if (transform.position.y >= limite)
        {
            Destroy(gameObject);
        }


    }
}
