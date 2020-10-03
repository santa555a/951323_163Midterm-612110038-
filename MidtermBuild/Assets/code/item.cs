using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour
{
    public int time;
    public int scoreUp;
    public static item instant;
    void Start()
    {
        instant = this;
    }

    
    void Update()
    {

    }
    public void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            Destroy(gameObject);
            timeshow.instant.timecount += time;
            timeshow.instant.score += scoreUp;
        }
    }
}
