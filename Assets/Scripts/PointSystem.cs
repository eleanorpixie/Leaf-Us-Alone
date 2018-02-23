using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour {

    [SerializeField]
    private Text text;

    private int points;
    private void Awake()
    {
        text = GetComponent<Text>();
        DontDestroyOnLoad(this);
    }

	// Use this for initialization
	void Start ()
    {
        points = 0;
	}
    private void Update()
    {
        text.text = "Points: " + points;
    }

    public void AddPoints(int pointamount)
    {
        points += pointamount;
    }
}
