using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collector : MonoBehaviour
{
    private int counter;

    void Start()
    {
        counter = 0;
    }

    private void OnTriggerEnter(Collider other)

    {
        
        if (other.gameObject.CompareTag("CollectItem"))
        {
            counter = counter + 1;
            other.gameObject.SetActive(false);


        }

    }
}