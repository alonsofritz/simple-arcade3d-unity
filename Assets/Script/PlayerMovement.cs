using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    // This is a reference to the value fowardForce, now is a variable public editable in the Unity interface
    public float fowardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    void Start() {
        Debug.Log("Work!");
    }

    // Update is called once per frame

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics
    void FixedUpdate () {

        // Add a forward force
        rb.AddForce(0, 0, fowardForce * Time.deltaTime);   // Add a force of 2000 on the z-axis

        if ( Input.GetKey("d") ) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }
        if ( Input.GetKey("a") ) {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
