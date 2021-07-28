using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maker_Red : MonoBehaviour
{
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
         //InvokeRepeating("Create_Red", 3.0f, TiempoCreacion);

        
    }

    public void Generar()
    {
        InvokeRepeating("Create_Red", 0.0f, TiempoCreacion);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey("r"))
        //{
        //    Create_Red();
        //}

        //if (Balloon.transform.position.y == 200)
        //{
        //    Destroy(Balloon);
        //}

    }

    public void Create_Red()
    {
        //float min = 0;
        //float max = 0;

        //if (Color == "Red")
        //{
        //    min = 455.4778f;
        //    max = 470.4778f;
        //    Debug.Log("Red");

        //}
        //else if (Color == "Blue")
        //{
        //    min = 439.4778f;
        //    max = 455.4778f;
        //    Debug.Log("Blue");
        //}
        //else if (Color == "Green")
        //{
        //    min = 445.4778f;
        //    max = 460.4778f;
        //    Debug.Log("Green");
        //}

        //Medidas para los globos azules
        // float XRandom = Random.Range(439.4778f, 455.4778f);

        //Medidas para los globos rojos
        // float XRandom = Random.Range(455.4778f, 470.4778f);

        //Medidas para los globos verdes
        // float XRandom = Random.Range(445.4778f, 460.4778f);


        //Generador de números aleatorios
        float XRandom = Random.Range(min, max);


        //Vector3 SpawPosition = new Vector3(XRandom, 153.7f, 0);
        Vector3 SpawPosition; ;

        //SpawPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawPosition = new Vector3(/*SpawPosition.x*/XRandom, y, z);

        Balloon = Instantiate(Balloons, SpawPosition, Quaternion.identity);
    }

}
