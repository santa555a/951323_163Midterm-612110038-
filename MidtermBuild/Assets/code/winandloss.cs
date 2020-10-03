using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winandloss : MonoBehaviour
{
    bool timedead;
    int timecount;
    bool timewin;
    int timewincount;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timedead == true)
            timecount++;
        if (timewin == true)
            timewincount++;
    }
    public void OnCollisionStay(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "dead" || timeshow.instant.timecount == 0)
        {
            timedead = true;
            Audiosound.instant.selectcardd();
        }
        if (collisionInfo.collider.tag == "win")
        {

            Audiosound.instant.playcardd();
            timewin = true;
        }
        if (timewincount >= 450)
        {
            SceneManager.LoadScene("scene2");
           
        }
        if (timecount >= 450)
        {
            SceneManager.LoadScene("SceneMainMenu");
            Audiosound.instant.selectcardd();
        }
    }
}
