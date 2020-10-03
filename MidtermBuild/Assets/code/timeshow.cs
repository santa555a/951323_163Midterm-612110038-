using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timeshow : MonoBehaviour
{
    public int score;
    public int timecount=60;
    public float timesecond;

    public TextMeshProUGUI TimeText;
    public TextMeshProUGUI ScoreText;
    public static timeshow instant;
    void Start()
    {
        instant = this;
    }

    // Update is called once per frame
    void Update()
    {
        timesecond+= Time.deltaTime; ;
        TimeText.text = "" + timecount;
        ScoreText.text = "" + score;
        if (timesecond >= 1)
        {
            timecount -= 1;
            timesecond = 0;
        }
    }
}
