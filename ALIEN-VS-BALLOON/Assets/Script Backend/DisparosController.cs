using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparosController : MonoBehaviour
{
    public float velocidad = -3.0f;

    Rigidbody2D rb;
    private List<string> GloboTag = new List<string>() { "rojo", "verde", "azul" };
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
  
    void Update()
    {
        rb.velocity = new Vector2(+velocidad, 0);
        Destroy(gameObject, 3.0f);
    }

    private void OnTriggerEnter2D(Collider2D objeto)
    {
        if (GloboTag.Contains(objeto.tag))
        {
            if (objeto.tag == "azul")
            {
                HUDHelioLifeBar helioDisponible = GameObject.FindGameObjectWithTag("Player").GetComponent<HUDHelioLifeBar>();
                helioDisponible.vidaActual += 10f;
            }
            else if (objeto.tag == "verde")
            {
                HUDHelioLifeBar helioDisponible = GameObject.FindGameObjectWithTag("Player").GetComponent<HUDHelioLifeBar>();
                helioDisponible.vidaActual += 1f;
            }
            else if (objeto.tag == "rojo")
            {
                HUDHelioLifeBar helioDisponible = GameObject.FindGameObjectWithTag("Player").GetComponent<HUDHelioLifeBar>();
                helioDisponible.vidaActual += 1f;
            }
            ObjectDesttroy(objeto.tag, objeto.gameObject, gameObject);
        }
    }

    private void ObjectDesttroy(string txt, GameObject globo, GameObject bala)
    {
        Debug.Log($"el globo {txt} fue destruido ");
        Destroy(globo);
        Destroy(bala);
    }

}

