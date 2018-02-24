using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretPlacementArea : MonoBehaviour {
    public Color hovercolor;
    public Vector3 positionOffset;
    private GameObject turret;

    private Renderer rend;
    public Color startColor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }
    void OnMouseOver()
    {
        if (Input.GetButtonDown("PlaceTurret"))
        {
            if (turret != null)
            {
                Debug.Log("Cannot build turret here");
                return;
            }
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);
    }
    void OnMouseEnter()
    {
        rend.material.color = hovercolor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
