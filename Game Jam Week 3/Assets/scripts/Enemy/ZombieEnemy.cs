using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieEnemy : MonoBehaviour
{
    private NavMeshAgent agent;
    
    public Transform player;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        MoveToPlayer();
    }

    private void MoveToPlayer()
    {
        agent.SetDestination(player.position);
        RotateToPlayer();
    }

    private void RotateToPlayer()
    {
        transform.LookAt(player);

        Vector3 direction = player.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = rotation;
    }


}
