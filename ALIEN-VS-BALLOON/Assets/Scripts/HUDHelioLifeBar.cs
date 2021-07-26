using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDHelioLifeBar : MonoBehaviour
{
    public Image barraHelio;

    public float vidaActual;
    public float vidaMaxima;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        barraHelio.fillAmount = vidaActual / vidaMaxima;
    }
}
