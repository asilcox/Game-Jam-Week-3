using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SpyEnemy : MonoBehaviour
{
    public NavMeshAgent agent;

    public float radius;

    public LayerMask whatIsPlayer;

    public Transform player;

    public float sightRange;

    public bool playerIsInRange;

    // Start is called before the first frame update
    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        playerIsInRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

        if (!playerIsInRange) Patrol();

        if (playerIsInRange) Chase();

    }

    void Patrol()
    {
        if (!agent.hasPath)
        {
            agent.SetDestination(GetPoint.Instance.GetRandomPoint(transform, radius));
        }
    }

    void Chase()
    {
        agent.SetDestination(player.position);
    }
}
