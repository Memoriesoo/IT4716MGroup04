using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPreviousCard : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Placed")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Chest")
        {
            Destroy(this);
        }
    }
}