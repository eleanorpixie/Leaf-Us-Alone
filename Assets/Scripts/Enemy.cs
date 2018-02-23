using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int enemyHordeAmount;

    [SerializeField]
    List<Rigidbody> rgd;

    [SerializeField]
    List<BoxCollider> bc;

    public int hordeIncreaseTimeDelay;

	// Use this for initialization
	void Start ()
    {
        enemyHordeAmount = 5;

        rgd = new List<Rigidbody>();

        bc = new List<BoxCollider>();

        hordeIncreaseTimeDelay = 20;

	}
	
	// Update is called once per frame
	void Update ()
    {
        StartCoroutine(MyCoroutine(hordeIncreaseTimeDelay));
	}

    IEnumerator MyCoroutine(int delay)
    {
        yield return new WaitForSeconds(3f);
    }
}
