using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


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

        if (vidaActual >= 500)
        {

            SceneManager.LoadScene("NextLevelScene");



        }
        else if (vidaActual <= 0)
        {

            GetComponent<NaveControlller>().explosion.Play();
            enabled = false;

            StartCoroutine(ExecuteAfterTime(2));


        }

    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);

        SceneManager.LoadScene("GameOverScene");

    }
}

