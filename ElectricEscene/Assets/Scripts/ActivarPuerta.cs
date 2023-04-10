using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class ActivarPuerta : MonoBehaviour
{
    public Animator animator;
    public GameObject puerta1;
    public GameObject puerta2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            animator.SetBool("Activate", true);
        }
        else if (Input.GetKeyDown("w"))
        {
            animator.SetBool("Activate", false);
        }

        if (Input.GetKeyDown("e"))
        {
            animator.SetBool("Active", true);
        }
        else if (Input.GetKeyDown("w"))
        {
            animator.SetBool("Active", false);
        }
    }
}
