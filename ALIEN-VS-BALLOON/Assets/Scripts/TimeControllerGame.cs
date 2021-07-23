using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeControllerGame : MonoBehaviour
{
    [SerializeField] int min, seg;
    [SerializeField] Text time_;

    private float TimeLeft;
    private bool Time_on;

    public void Awake()
    {
        TimeLeft += (min * 60) + seg;
        Time_on = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time_on)
        {
            TimeLeft += Time.deltaTime;
            if (TimeLeft < 1)
                Time_on = true;
           
            int MinTime = Mathf.FloorToInt(TimeLeft / 60);
            int SegTime = Mathf.FloorToInt(TimeLeft % 60);

            time_.text = string.Format("{00:00}:{01:00}", MinTime, SegTime);
        }

    }
}
