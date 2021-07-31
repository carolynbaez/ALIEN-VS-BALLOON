using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonsController : MonoBehaviour
{
    public GameObject Balloon;

    Maker_Red Objeto = new Maker_Red();

    bool Call = true;

    //Variable para modfificar la velocidad de los globos
    //public float Velocidad = 0.3f;
    public float Velo;

    float y;

    //public float increment;
    //public bool fast;
    public int min;
    public int max;
    public float limite;




    // Start is called before the first frame update
    //int Start()
    //{
    //    if (Call == true)
    //    {
    //        Velo = Random.Range(1, 10);
    //    }
        
    //    return Velo;
    //}

    // Update is called once per frame
    void Update()
    {
        if (Call == true)
        {
            Velo = Random.Range(min, max);
            Call = false;

        }
        
       // y = GetComponent<Transform>().position.y; 
        transform.position += transform.up * Velo* Time.deltaTime;
        if (transform.position.y >= limite)
        {
            Destroy(gameObject);
        }
        
    }
}
