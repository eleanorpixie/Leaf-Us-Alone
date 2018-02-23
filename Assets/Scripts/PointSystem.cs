using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour {

    private int points;
    private int pointAmount;
    public int Points//i think the only script that needs to change the point amount is this one...
    {
        get
        {
            return points;
        }
    }
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

	// Use this for initialization
	void Start ()
    {
        points = 0;
	}

    void AddPoints()
    {
        points += pointAmount;
    }
}
