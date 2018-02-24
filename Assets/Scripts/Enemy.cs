using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {
    public int enemyHordeAmount;

    public int hordeIncreaseTimeDelay;

    public int increaseAmount;

    GameObject lumberJack;

    GameObject termite;

    bool stop;

    [SerializeField] private List<Transform> Spawn;
    [SerializeField] private List<Transform> Destination;

    
    public Transform spawnPoint;
    public Transform destination;

    public Transform spawnPoint1;
    public Transform destination1;

    public Transform spawnPoint2;
    public Transform destination2;

    public Transform spawnPoint3;
    public Transform destination3;

    private NavMeshAgent enemy;


    // Use this for initialization
    void Start ()
    {
        stop = true;

        Spawn.Add(spawnPoint);
        Destination.Add(destination);

        Spawn.Add(spawnPoint1);
        Destination.Add(destination1);

        Spawn.Add(spawnPoint2);
        Destination.Add(destination2);

        Spawn.Add(spawnPoint3);
        Destination.Add(destination3);
        
        
        lumberJack = GameObject.FindGameObjectWithTag("lumberjack1");
        
        termite = GameObject.FindGameObjectWithTag("termite1");


        lumberJack.GetComponent<Renderer>().enabled = false;

        termite.GetComponent<Renderer>().enabled = false;


        for (int n = 0; n < 3; n++)
        {
            System.Random rnd = new System.Random();
            Thread.Sleep(200);
            int ranType2 = rnd.Next(0, 4);

            GameObject g = Instantiate(lumberJack);
            enemy = g.GetComponent<NavMeshAgent>();



            enemy.Warp(Spawn[ranType2].position);
            enemy.destination = Destination[ranType2].position;
            g.GetComponent<Renderer>().enabled = true;


        }

        for (int k = 0; k < 2; k++)
        {
            System.Random rnd = new System.Random();
            Thread.Sleep(200);
            int ranType1 = rnd.Next(0, 4);

            GameObject g = Instantiate(termite);
            enemy = g.GetComponent<NavMeshAgent>();


            enemy.Warp(Spawn[ranType1].position);
            enemy.destination = Destination[ranType1].position;
            g.GetComponent<Renderer>().enabled = true;
            
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
            Thread.Sleep(200);
            int ranType = rnd.Next(1, 3);

            if (ranType == 1)
            {

                System.Random rng = new System.Random();
                Thread.Sleep(10);
                int ranType1 = rng.Next(0, 4);

                GameObject g = Instantiate(lumberJack);
                enemy = g.GetComponent<NavMeshAgent>();


                enemy.Warp(Spawn[ranType1].position);
                enemy.destination = Destination[ranType1].position;
                g.GetComponent<Renderer>().enabled = true;

            }
            else if (ranType == 2)
            {
                System.Random rng = new System.Random();
                Thread.Sleep(10);
                int ranType1 = rng.Next(0, 4);

                GameObject g = Instantiate(termite);
                enemy = g.GetComponent<NavMeshAgent>();


                enemy.Warp(Spawn[ranType1].position);
                enemy.destination = Destination[ranType1].position;
                g.GetComponent<Renderer>().enabled = true;
            }
        }
    stop = true;
    

    }
}
