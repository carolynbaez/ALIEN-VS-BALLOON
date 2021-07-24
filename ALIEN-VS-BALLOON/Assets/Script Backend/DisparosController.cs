using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparosController : MonoBehaviour
{
    // Start is called before the first frame update
    //public float disparoX;
    //float disparoY = 0;
    public float velocidad = -3.0f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(+velocidad, 0);
        Destroy(gameObject, 2.10f);
    }
}
