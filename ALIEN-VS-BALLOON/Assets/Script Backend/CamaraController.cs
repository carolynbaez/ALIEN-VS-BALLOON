using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    ////Contiene los datos de la nave
    //public GameObject Target;
    ////Para guardar la informacion del personaje y la camara
    //private Vector3 TargetPost;
    //// Start is called before the first frame update

    //private Vector2 limitePantalla;
    //private float ObjectAncho;
    //private float ObjetoAlto;

    //public Camera MainCamera;
    //private Vector2 screenBounds;
    //private float objectWidth;
    //private float objectHeight;

    void Start()
    {
        //limitePantalla = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //ObjectAncho = transform.GetComponent<SpriteRenderer>().bounds.size.x / 2;
        //ObjetoAlto = transform.GetComponent<SpriteRenderer>().bounds.size.y / 2 ;
        //screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        //objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x; //extents = size of width / 2
        //objectHeight = transform.GetComponent<SpriteRenderer>().bounds.extents.y; //extents = size of height / 2


    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x,-2f,2f),Mathf.Clamp(transform.position.y,-6f,5f), transform.position.z);
        //transform.position = new Vector3(Target.transform.position.x, Target.transform.position.y, transform.position.z);
        //Vector3 ViewPort = transform.position;
        //ViewPort.x = Mathf.Clamp(ViewPort.x, limitePantalla.x + ObjectAncho, limitePantalla.x * -1 - ObjectAncho);
        //ViewPort.y = Mathf.Clamp(ViewPort.y, limitePantalla.y + ObjetoAlto, limitePantalla.y * -1 - ObjetoAlto);
        //transform.position = ViewPort;

        //Vector3 viewPos = transform.position;
        //viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
        //viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y * -1 + objectHeight, screenBounds.y - objectHeight);
        //transform.position = viewPos;
    }
}
