using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour {

    [SerializeField]
    private Text text;

    public static int points;

    public int iPointsTemp = points;

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
        text.text = "Points: " + iPointsTemp;


    }

    public static void AddPoints(int pointamount)
    { 
        points += pointamount;
    }
}
