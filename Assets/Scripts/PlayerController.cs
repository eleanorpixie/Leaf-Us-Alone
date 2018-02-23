﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed = 50.0f;

    private Quaternion rotate = Quaternion.identity;

    private int rotateY;

    [System.Serializable]
    public class Boundary
    {
        public float xMin, xMax, zMin, zMax;
    }

    public Boundary boundary;

    // Use this for initialization
    void Start ()
    {
        gameObject.transform.rotation = rotate;
	}

    private void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            rotateY = 0;
        }

        if (Input.GetKeyDown("right"))
        {
            rotateY = 90;
        }

        if (Input.GetKeyDown("down"))
        {
            rotateY = 180;
        }

        if (Input.GetKeyDown("left"))
        {
            rotateY = 270;
        }

        rotate.eulerAngles = new Vector3(0, rotateY, 0);

        gameObject.transform.rotation = rotate;
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 5.0f;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;

        Rigidbody rb = GetComponent<Rigidbody>();

        Vector3 move = new Vector3(x, 0, z);

        rb.position = new Vector3
        (
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),
            0.5f,
            Mathf.Clamp(rb.position.z, boundary.zMin, boundary.zMax)
        );

        rb.velocity = move * speed;
	}
}
