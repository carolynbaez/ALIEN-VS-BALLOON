using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maker_Blue : MonoBehaviour
{
    public GameObject Balloons;

    GameObject Balloon;

    public float TiempoCreacion = 3f;

    public float RangoCreacion = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Create_Red", 3.0f, TiempoCreacion);


    }

    public void Generar()
    {
        InvokeRepeating("Create_Blue", 3.0f, TiempoCreacion);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("b"))
        {
            Create_Blue();
        }

        //if (Balloon.transform.position.y == 200)
        //{
        //    Destroy(Balloon);
        //}

    }

    public void Create_Blue()
    {
        //Generador de números aleatorios
        float XRandom = Random.Range(455.4778f, 470.4778f);


        //Vector3 SpawPosition = new Vector3(XRandom, 153.7f, 0);
        Vector3 SpawPosition; ;

        //SpawPosition = this.transform.position + Random.onUnitSphere * RangoCreacion;
        SpawPosition = new Vector3(/*SpawPosition.x*/XRandom, 153.5f, -3220.257f);

        Balloon = Instantiate(Balloons, SpawPosition, Quaternion.identity);
    }

}
