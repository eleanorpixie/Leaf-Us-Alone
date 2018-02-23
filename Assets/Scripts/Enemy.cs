using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public int enemyHordeAmount;

    public int hordeIncreaseTimeDelay;

    public int increaseAmount;

    GameObject lumberJack;

    GameObject termite;

    bool stop;


	// Use this for initialization
	void Start ()
    {
        stop = true;

        lumberJack = GameObject.FindGameObjectWithTag("lumberjack1");
        termite = GameObject.FindGameObjectWithTag("termite1");

        lumberJack.GetComponent<Renderer>().enabled = false;

        termite.GetComponent<Renderer>().enabled = false;

        enemyHordeAmount = 5;

        hordeIncreaseTimeDelay = 30;

        

       
            for(int n = 0; n < 3;n++)
            {
                GameObject g = Instantiate(lumberJack);
                g.GetComponent<Renderer>().enabled = true;
            }

            for (int k = 0; k < 2; k++)
            {
                GameObject o = Instantiate(termite);
                o.GetComponent<Renderer>().enabled = true;
            }


    }
	
	// Update is called once per frame
	void LateUpdate ()
    {
        if (stop == true)
            StartCoroutine(MyCoroutine(hordeIncreaseTimeDelay));
      
	}

    IEnumerator MyCoroutine(int delay)
    {
        stop = false;
        yield return new WaitForSeconds(delay);
            enemyHordeAmount += increaseAmount;
            for (int l = 0; l < 7; ++l)
            {
                System.Random rnd = new System.Random();
                int ranType = rnd.Next(0, 4);

                if (ranType == 1)
                {
                    GameObject g = Instantiate(lumberJack);
                    g.GetComponent<Renderer>().enabled = true;
                    Console.WriteLine("lumberjack");
                }
                else if (ranType == 2)
                {
                    GameObject o = Instantiate(termite);
                    o.GetComponent<Renderer>().enabled = true;
                    Console.WriteLine("termite");
                }
            }
        stop = true;
    
    }
}
