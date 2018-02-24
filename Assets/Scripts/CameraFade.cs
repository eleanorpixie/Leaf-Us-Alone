using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFade : MonoBehaviour
{
    private float alphaStart = 1f;
    private float alphaEnd = 0.2f;
    private float duration = 1f;

    private Renderer rend;

    private bool isColliding;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        isColliding = false;
    }

    private void Update()
    {
        float lerp = Mathf.PingPong(Time.time, duration) / duration;

        if (isColliding)
        {
            //rend.material.color = new Color(255, 255, 255, 100);
        }
        else
        {
            //rend.material.color = new Color(255, 255, 255, 255);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            isColliding = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            isColliding = false;
        }
    }
}
