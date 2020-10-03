using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollisionCheckWithITC : MonoBehaviour
{
    public Text _textPickUpInfo;
    void Start()
    {

    }


    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        ItemTypeComponent itc = collision.gameObject.GetComponent<ItemTypeComponent>();
        if (itc != null)
        {
            switch (itc.Type)
            {
                case ItemType.SPHERE_DROP_ITEM:
                    _textPickUpInfo.text = "SPHERE_DROP_ITEMhasbeenpickedup";
                    break;
                case ItemType.CUBE_OBSTACLE:
                    _textPickUpInfo.text = "CUBE_OBSTACLEhasbeenpickedup";
                    break;
                case ItemType.CAPSULE_OBSTACLE:
                    _textPickUpInfo.text = "CAPSULE_OBSTACLEhasbeenpickedup";
                    break;
                case ItemType.CYLINDER_OBSTACLE:
                    _textPickUpInfo.text = "CYLINDER_OBSTACLEhasbeenpickedup";
                    break;
                case ItemType.hee_OBSTACLE:
                    _textPickUpInfo.text = "hee_OBSTACLEhasbeenpickedup";
                    break;
                case ItemType.sae_OBSTACLE:
                    _textPickUpInfo.text = "sae_OBSTACLEhasbeenpickedup";
                    break;
            }
        }
    }
}

