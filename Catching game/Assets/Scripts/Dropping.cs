using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = System.Random;

public class Dropping : MonoBehaviour
{

    public DateTime nextspawn = DateTime.Now.AddSeconds(2);
    Random rand = new Random();
    public GameObject cubePrefab;

    private void FixedUpdate()
    {
        if (DateTime.Now >= nextspawn)
        {
            nextspawn = DateTime.Now.AddSeconds(rand.Next(1,5));
            
            if (rand.Next(1, 100)<= 20){
                Instantiate(cubePrefab, transform.position, Quaternion.Euler(90, 90, 90));
            }
        }
    }
}
