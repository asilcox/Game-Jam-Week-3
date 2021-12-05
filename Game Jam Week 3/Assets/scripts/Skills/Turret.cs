using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float time;

    public float radius;

    public LayerMask whatIsEnemy;

    public Transform enemy;

    public float sightRange;

    public bool enemyIsInRange;

    public GameObject bullet;

    public float firePower = 500f;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.FindWithTag("Enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
        enemyIsInRange = Physics.CheckSphere(transform.position, sightRange, whatIsEnemy);

        if (enemyIsInRange) Fire();
    }

     void Fire()
    {
        GameObject projectile = Instantiate(bullet, transform.position, transform.rotation);

        projectile.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, firePower, 0));
    }
}
