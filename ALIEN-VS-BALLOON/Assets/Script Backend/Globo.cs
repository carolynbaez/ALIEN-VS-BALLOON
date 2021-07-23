using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globo : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject asteroidPrefab;
    //public float respawnTime = 1.0f;
    //private Vector2 screenBounds;

    public GameObject globo;
    float maxSpawnRateSeconds = 5f;

    void Start()
    {
        //screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        //StartCoroutine(globosWave());

        Invoke("SpamGlobos", maxSpawnRateSeconds);
    }
    private void spamGlobos()
    {
        //GameObject a = Instantiate(asteroidPrefab) as GameObject;
        //a.transform.position = new Vector3(screenBounds.x * -2, Random.Range(-screenBounds.y, screenBounds.y),transform.position.z);
    }
    //IEnumerator globosWave()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(respawnTime);
    //        spamGlobos();
    //    }
    //}
    // Update is called once per frame


    //Spamear a los enemegigos

    void SpamGlobos()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        GameObject aGlobo = (GameObject)Instantiate(globo);
        aGlobo.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);
    }

}
