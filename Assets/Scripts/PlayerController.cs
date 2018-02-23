using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 50.0f;

    private Quaternion rotate = Quaternion.identity;

    private int rotateY;

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

        if (Input.GetKeyDown("up"))
        {
            rotateY = 0;
            Debug.Log("Rotated North.");
        }

        if (Input.GetKeyDown("right"))
        {
            rotateY = 90;
            Debug.Log("Rotated East.");
        }

        if (Input.GetKeyDown("down"))
        {
            rotateY = 180;
            Debug.Log("Rotated South.");
        }

        if (Input.GetKeyDown("left"))
        {
            rotateY = 270;
            Debug.Log("Rotated West.");
        }

        rotate.eulerAngles = new Vector3(0, rotateY, 0);

        gameObject.transform.rotation = rotate;
	}
}
