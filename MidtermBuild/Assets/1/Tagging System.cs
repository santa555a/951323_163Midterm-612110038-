using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaggingSystem : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag =="Item")
        {
            Debug.Log("DosomethingwithItem");
        }
        if (collision.gameObject.tag =="Player")
        { Debug.Log("DosomethingwithPlayer");
        } 
        }
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
