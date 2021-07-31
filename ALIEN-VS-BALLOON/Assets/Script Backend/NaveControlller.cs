using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveControlller : MonoBehaviour
{
    public float velocidad = 3.5f;
    public ParticleSystem explosion;
    // Start is called before the first frame update
    //private float velocidad_Cont = 2.5f;


    //Mientras movimiento sea verdadero
    public bool movimiento = true;
    void Start()
    {
        transform.position = new Vector3(10, 0, transform.position.z);
        //gameObject.transform.position = new Vector3(6,0,0);
     }
    // Update is called once per frame
    void Update()
    {
        ////Esta parte de codigo controla el movimiento de la nave en todas las direeciones, en un juego profesiona utiliza esto  
        //    transform.Translate(Input.GetAxis("Horizontal") * velocidad * Time.deltaTime,
        //                        Input.GetAxis("Vertical") * velocidad * Time.deltaTime,
        //                        transform.position.z);
        //
         ///Poder controlar si se mueve o no 
        if (movimiento){
            //transform.position += Vector3.left * velocidad_Cont * Time.deltaTime;

            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += Vector3.up * velocidad * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position += Vector3.down * velocidad * Time.deltaTime;
            }

        }

    }
}
