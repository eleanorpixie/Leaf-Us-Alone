using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD

public class PointSystem : MonoBehaviour {

    private int points = 0;
    public int Points
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
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


=======
using UnityEngine.UI;

public class PointSystem : MonoBehaviour {

    [SerializeField]
    private int pointAmount = 1;

    private Text text;

    private int points;

    //public int Points//i think the only script that needs to change the point amount is this one...
    //{
    //    get
    //    {
    //        return points;
    //    }
    //}
    private void Awake()
    {
        DontDestroyOnLoad(this);
        text = GetComponent<Text>();
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

    public void AddPoints()
    {
        points += pointAmount;
    }
>>>>>>> 875be52f0f439b701a798ca7c717124641402264
}
