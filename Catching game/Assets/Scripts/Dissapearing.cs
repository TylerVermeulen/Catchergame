using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
public class Dissapearing : MonoBehaviour
{
    public int CurrentScore = 0;

    

    private void FixedUpdate()
    {
        //text.text = "hello world";
       // scoreDisplay.GetComponent<Text>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Astrounalts")
        {
            gameObject.SetActive(false);
            CurrentScore++;
        }
    }
}
