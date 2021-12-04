using UnityEngine;
using UnityEngine.AI;
public class romanticlyShyEnemy : MonoBehaviour
{
    [Header("state machine")]
    public enemyStates currentState;

    [Header("AI Stuff")]
    [SerializeField] float aggroRange;
    [SerializeField] float escapeRange;
    [SerializeField] float roamDistance;
    [SerializeField] float shyDistance;
    [SerializeField] float navDistance;
    [SerializeField] Vector3 newTargetPos;
    [SerializeField] Transform playerTarget;
    [SerializeField] LayerMask maskLayer;
    private NavMeshAgent shyAgent;
    // Start is called before the first frame update
    void Start()
    {
        shyAgent = GetComponent<NavMeshAgent>();
        newPathPoint();
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case enemyStates.idle:
                {
                    if (Vector3.Distance(transform.position, playerTarget.position) <= aggroRange)
                    {
                        currentState = enemyStates.aggro;
                    }
                    break;
                }
            case enemyStates.shylyPatrol:
                {
                    shyAgent.SetDestination(newTargetPos);
                    if(Vector3.Distance(transform.position, newTargetPos) <= navDistance)
                    {
                        currentState = enemyStates.idle;
                        newPathPoint();
                    }

                    if(Vector3.Distance(transform.position, playerTarget.position) <= aggroRange)
                    {
                        currentState = enemyStates.aggro;
                    }
                    break;
                }
            case enemyStates.aggro:
                {
                    shyAgent.SetDestination(playerTarget.position);
                    if(Vector3.Distance(transform.position, playerTarget.position) >= escapeRange)
                    {
                        newPathPoint();
                        currentState = enemyStates.shylyPatrol;
                    }
                    break;
                }
            case enemyStates.death:
                {
                    break;
                }
        }
    }

    public void newPathPoint()
    {
        newTargetPos = new Vector3(Random.insideUnitSphere.x, 0 ,Random.insideUnitSphere.z) * roamDistance;

        
        if(Vector3.Distance(newTargetPos, playerTarget.position) <= shyDistance)
        {
            newPathPoint();
        }
        else
        {
            currentState = enemyStates.shylyPatrol;
        }
    }


    public enum enemyStates
    {
        idle,
        shylyPatrol,
        aggro,
        attack,
        takeDamage,
        death,
    }
}


