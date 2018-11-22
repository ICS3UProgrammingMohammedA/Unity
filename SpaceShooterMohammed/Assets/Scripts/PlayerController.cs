using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}



public class PlayerController : MonoBehaviour
{
    public float speed;
    public Boundary boundary;
    private Rigidbody rb;

    private void Start ()
    {
       rb  = GetComponent<Rigidbody>(); 
    }
    

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVerticale = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVerticale);
        rb.velocity = movement * speed;

        rb.position = new Vector3
        (
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            0.0f,
            Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        );
            

           
            
    }
}
