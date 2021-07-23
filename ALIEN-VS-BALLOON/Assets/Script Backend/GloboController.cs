using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloboController : MonoBehaviour
{
    //////public NaveControlller nave;
    //////public GameObject item;
    //////public float Radius = 1f;
    // Start is called before the first frame update

    //public float speed = 10.0f;
    //private Rigidbody2D rb;
    //private Vector2 limitePantalla;

    float velocidad;

    void Start()
    {
        //rb = this.GetComponent<Rigidbody2D>();
        //rb.velocity = new Vector2(-speed, 0);
        //limitePantalla = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width,Screen.height,Camera.main.transform.position.z));

        velocidad = 2f;
    }

    // Update is called once per frame
    void Update()
    {
        //if (transform.position.x < limitePantalla.x * 2)
        //{
        //    Destroy(this.gameObject);
        //}
        Vector2 position = transform.position;

        position = new Vector2(position.x - velocidad * Time.deltaTime, position.y);

        transform.position = position;

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        if (transform.position.x < min.x)
        {
            Destroy(gameObject);
        }
    }

    //void DuplicarGlobo()
    //{
    //    Vector3 randomPos = Random.insideUnitCircle * Radius;
    //    Instantiate(item, randomPos, Quaternion.identity);
    //}
}
