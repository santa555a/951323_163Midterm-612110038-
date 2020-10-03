using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnOptacle : MonoBehaviour
{
    public GameObject green;
    public GameObject red;
    public GameObject blue;
    public GameObject grey;
    Vector3 pointspawn;
    float timer;
    int random;
    public static spawnOptacle instant;
    void start()
    {
        instant = this;
    }
    void Update()
    {
        pointspawn.y = 7;
        timer += Time.deltaTime;
        if (timer >= 1)
        {
            random = Random.Range(1, 5);
            pointspawn.z = Random.Range(-6, 57);
            pointspawn.x = Random.Range(-2, 2);
            if (random == 1)
            {
                Instantiate(green, pointspawn, Quaternion.identity);
            }
            if (random == 2)
            {
                Instantiate(red, pointspawn, Quaternion.identity);
            }
            if (random == 3)
            {
                Instantiate(blue, pointspawn, Quaternion.identity);
            }
            if (random == 4)
            {
                Instantiate(grey, pointspawn, Quaternion.identity);
            }
            timer = 0;
        }
    }
}
