using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;

    public bool cubegrounded = true;
    public float forwardforce = 2000f;
    public float leftforce = 600f;
    public float rightforce = 600f;

    public float upforce = 500f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collisioninfo)
    {
        Debug.Log(collisioninfo.collider.name);
        if (collisioninfo.collider.name == "Ground")
        {
            cubegrounded = true;
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, 20);
        // rb.AddForce(0,0,forwardforce*Time.deltaTime);
        if (!Input.anyKey)
        {
            Debug.Log(rb.velocity);
        }




        if(Input.GetKey("d")){
            rb.AddForce(leftforce*Time.deltaTime,0,0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a")){
            rb.AddForce(-rightforce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if (Input.GetKey("space") && cubegrounded == true){
            cubegrounded = false;
            rb.AddForce(Vector3.up * upforce);


            rb.AddForce(0,upforce*Time.deltaTime,0,ForceMode.VelocityChange);
            // rb.AddForce(0, upforce*Time.deltaTime,0,ForceMode.VelocityChange);
        }
    }
    
}
