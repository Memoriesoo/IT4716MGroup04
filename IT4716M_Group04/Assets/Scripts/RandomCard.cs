using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCard : MonoBehaviour
{
    public GameObject ItemPrefeb;
    public float rate = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Duplicate", 0, rate);
    }

    // Update is called once per frame
    void Duplicate()
    {
        GameObject clone = Instantiate(ItemPrefeb, transform.position, Quaternion.identity);

    }
}
