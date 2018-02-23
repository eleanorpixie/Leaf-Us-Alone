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

	// Use this for initialization
	void Start ()
    {
        lumberJack = GameObject.FindGameObjectWithTag("lumberjack");
        termite = GameObject.FindGameObjectWithTag("termite");

        lumberJack.SetActive(false);
        termite.SetActive(false);

        enemyHordeAmount = 5;

        hordeIncreaseTimeDelay = 20;

        

        for(int i = 0;i<enemyHordeAmount;i++)
        {
            for(int n = 0; n<3;n++)
            {
                Instantiate(lumberJack);
                this.gameObject.SetActive(true);
            }

            for (int k = 0; k < 2; k++)
            {
                Instantiate(termite);
                this.gameObject.SetActive(true);
            }

        }


	}
	
	// Update is called once per frame
	void Update ()
    {
        StartCoroutine(MyCoroutine(hordeIncreaseTimeDelay));
	}

    IEnumerator MyCoroutine(int delay)
    {
        yield return new WaitForSeconds(delay);

        enemyHordeAmount += increaseAmount;
        for (int i = 0; i < increaseAmount; i++)
        {
            System.Random rnd = new System.Random();
            int ranType = rnd.Next(1, 3);

            if(ranType==1)
            {
                Instantiate(lumberJack);
                this.gameObject.SetActive(true);
            }
            else if(ranType==2)
            {
                Instantiate(termite);
                this.gameObject.SetActive(true);
            }
        }
    }
}
