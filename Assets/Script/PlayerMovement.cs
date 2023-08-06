using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start() {
        Debug.Log("Work!");
    }

    // Update is called once per frame

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics
    void FixedUpdate () {
        rb.AddForce(0, 0, 2000 * Time.deltaTime);   // Add a force of 2000 on the z-axis
    }
}
