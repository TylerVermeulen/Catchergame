using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapearing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Astrounalts")
        {

            //Vector3 v1= collision.gameObject.transform.position;
            //Vector3 v2 = gameObject.transform.position;
           // Vector3 diff = v1 - v2;
           // collision.gameObject.GetComponent<Rigidbody>().velocity = diff; 
            gameObject.SetActive(false);

        }
    }
}
