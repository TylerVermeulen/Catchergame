using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Game_Over : MonoBehaviour
{
    public int CurrentLife = 5;



    private void FixedUpdate()
    {
        //text.text = "hello world";
        // scoreDisplay.GetComponent<Text>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            Destroy(gameObject);
            GameObject.FindGameObjectWithTag("Player").GetComponent<Controller>().health--;
        }

    }
}
