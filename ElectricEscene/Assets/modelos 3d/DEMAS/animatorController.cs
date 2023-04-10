using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorController : MonoBehaviour
{
    private Animator animator;
    private bool extender = true;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public  void despliegue(){
            if(extender == true){
               animator.SetBool("extender",true);
               extender = false;
            }
            else {if (extender == false){
                animator.SetBool("extender",false);
                extender = true;
            }
            }
    }
}
