using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour

{
    public float speed;
    public int health = 5;
    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");

        
        if (horizontal != 0)
        {
            if(horizontal > 0)
            {
                 transform.rotation = Quaternion.Euler(0, 90, 0);

            }
            else
            {
                transform.rotation = Quaternion.Euler(0, -90, 0);

            }
            animator.SetBool("IsWalking", true);
        }
        else animator.SetBool("IsWalking", false);

        if (health == 0)
        {
            SceneManager.LoadScene("Catcher");

        }
    }

}
