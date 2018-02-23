using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schut : MonoBehaviour {

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

    private float nextFire;
    private int shotDirection;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);


        }
	}
}
