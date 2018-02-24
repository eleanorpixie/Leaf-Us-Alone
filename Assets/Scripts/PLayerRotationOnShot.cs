using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerRotationOnShot : MonoBehaviour {
    private Quaternion rotate = Quaternion.identity;

    private int rotateY;

    [System.Serializable]
    public class Boundary
    {
        public float xMin, xMax, zMin, zMax, playerHeight;
    }

    public Boundary boundary;

    // Use this for initialization
    void Start()
    {
        gameObject.transform.rotation = rotate;
    }
    private void Update()
    {
        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            if (Input.GetKey("left") || Input.GetKey("a"))
            {
                rotateY = 315;
            }
            else if (Input.GetKey("right") || Input.GetKey("d"))
            {
                rotateY = 45;
            }
            else
            {
                rotateY = 0;
            }
        }

        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            if (Input.GetKey("up") || Input.GetKey("w"))
            {
                rotateY = 45;
            }
            else if (Input.GetKey("down") || Input.GetKey("s"))
            {
                rotateY = 135;
            }
            else
            {
                rotateY = 90;
            }
        }

        if (Input.GetKey("down") || Input.GetKey("s"))
        {
            if (Input.GetKey("left") || Input.GetKey("a"))
            {
                rotateY = 225;
            }
            else if (Input.GetKey("right") || Input.GetKey("d"))
            {
                rotateY = 135;
            }
            else
            {
                rotateY = 180;
            }
        }

        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            if (Input.GetKey("up") || Input.GetKey("w"))
            {
                rotateY = 315;
            }
            else if (Input.GetKey("down") || Input.GetKey("s"))
            {
                rotateY = 225;
            }
            else
            {
                rotateY = 270;
            }
        }

        rotate.eulerAngles = new Vector3(0, rotateY, 0);

        gameObject.transform.rotation = rotate;
    }
}
