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

        var rotateZ = 0;

        Rigidbody rb = GetComponent<Rigidbody>();

        Vector3 move = new Vector3(x, 0, z);
        Quaternion rotate = new Quaternion(0, 0, rotateZ, 0);

        rb.velocity = move * speed;

        if (Input.GetKeyDown("up"))
        {
            rotateZ = 0;
        }

        if (Input.GetKeyDown("right"))
        {
            rotateZ = 90;
        }

        if (Input.GetKeyDown("down"))
        {
            rotateZ = 180;
        }

        if (Input.GetKeyDown("left"))
        {
            rotateZ = 270;
        }

        rb.transform.rotation = rotate;
	}
}
