using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
       rb  = GetComponent<Rigidbody>(); 
    }
    

    private void FixedUpdate()
    {
        float mozeHorizontal = Input.GetAxis("Horizontal");
        float moveVerticale = Input.GetAxis("Verticale");

        Vector3 movement = new Vector3(mozeHorizontal, 0.0f, moveVerticale);
        rb.velocity = movement;
    }
}
