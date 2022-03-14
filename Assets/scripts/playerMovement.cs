using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;    // rb is just a name we called our rigidbody thingy
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upForce = 10000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //  we use FixedUpdate instead of Update while using physics & multiply with Time.deltaTime so it would run same on all computers

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 
        if(Input.GetKey("d"))
            {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }
        if(Input.GetKey("a"))
            {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(0, upForce * Time.deltaTime, 0);
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<gameManager>().GameOver();
        }

    }
}
