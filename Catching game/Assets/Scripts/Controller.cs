using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed;
    [SerializeField] private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");

        transform.Translate(horizontal * Time.deltaTime * speed, 0f, 0f);
        
        if (horizontal != 0)
        {
            animator.SetBool("IsWalking", true);
        }
        else animator.SetBool("IsWalking", false);
    }

}
