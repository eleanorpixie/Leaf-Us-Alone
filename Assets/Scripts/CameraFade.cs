using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFade : MonoBehaviour
{
    [SerializeField] private Material toonMaterial;
    [SerializeField] private Material transparentMaterial;

    [HideInInspector] public bool CameraColliding;
    [HideInInspector] public bool PlayerColliding;

    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        CameraColliding = false;
        PlayerColliding = false;
    }

    private void Update()
    {
        if (CameraColliding || PlayerColliding)
        {
            rend.material = transparentMaterial;
        }
        else
        {
            rend.material = toonMaterial;
        }
    }
}
