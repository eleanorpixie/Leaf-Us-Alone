using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour {

    [SerializeField]
    private Text text;

    public static int points;

    public int iPointsTemp;

    private void Awake()
    {
        //text = this.GetComponent<Text>();
        DontDestroyOnLoad(this);
    }

	// Use this for initialization
	void Start ()
    {
        points = 0;
	}
    private void Update()
    {
        iPointsTemp = points;
        text.text = "Points: " + iPointsTemp;

    }

    public static void AddPoints(int pointamount)
    { 
        points += pointamount;
    }
}
