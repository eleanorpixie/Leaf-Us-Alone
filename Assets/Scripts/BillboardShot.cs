using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillboardShot : MonoBehaviour
{
    [SerializeField]
    private Transform mainCamera;

    private void LateUpdate()
    {
            transform.rotation = mainCamera.transform.rotation;
    }
}
