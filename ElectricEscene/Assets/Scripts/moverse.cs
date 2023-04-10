using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverse : MonoBehaviour
{
    private new Rigidbody rigidbody;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movimiento();
    }

    private void  movimiento (){
        float hor  = Input.GetAxisRaw("Horizontal");
        float ver  = Input.GetAxisRaw("Vertical");

        Vector3 velocity;

        if(hor != 0 || ver != 0 ){
            velocity = (transform.forward * ver + transform.right * hor).normalized * speed;
        } else {
            velocity = Vector3.zero;
        }

        velocity.y = rigidbody.velocity.y;
        rigidbody.velocity = velocity;
    }
    
}
