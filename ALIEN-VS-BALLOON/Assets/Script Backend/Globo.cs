using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globo : MonoBehaviour
{
    //public GameObject globoPrefab;
    //public float respawnTime = 1.0f;
    //private Vector2 screenBounds;


    void Start()
    {
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //StartCoroutine(globosWave());
    }
    private void spamGlobos()
    {
        //GameObject clon = Instantiate(globoPrefab) as GameObject;
        //clon.transform.position = new Vector2(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y));
    }
 

    //IEnumerator globosWave()
    //{
    //    //while (true)
    //    //{
    //    //    yield return new WaitForSeconds(respawnTime);
    //    //    spamGlobos();

    //    //}
    //}

}
