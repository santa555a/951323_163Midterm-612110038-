using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winandloss : MonoBehaviour
{
   
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    public void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "dead" || timeshow.instant.timecount == 0)
        {
            SceneManager.LoadScene("SceneMainMenu");

        }
        if (collisionInfo.collider.tag == "win")
        {
            
            SceneManager.LoadScene("scene2");

        }
    }
}
