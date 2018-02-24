using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToDestination : MonoBehaviour
{
    [SerializeField]
    private Transform destination;
    private NavMeshAgent enemy;

    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        enemy.destination = destination.position;
    }
}
