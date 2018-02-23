using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 50.0f;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;

        Rigidbody rb = GetComponent<Rigidbody>();

        Vector3 move = new Vector3(x, 0, z);

        rb.velocity = move * speed;
	}
}
