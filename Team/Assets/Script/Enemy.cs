using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [SerializeField] int hp;
    public int damage = 100;

    public Transform target;
    NavMeshAgent navAgent;


    private void Awake()
    {
        navAgent = GetComponent<NavMeshAgent>();

    }

    void Update()
    {
        navAgent.SetDestination(target.position);
    }


}
