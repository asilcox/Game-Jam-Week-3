using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    public Transform enemySpawner;
    
    public Transform enemy;

    private void Awake()
    {
        enemySpawner = GameObject.FindWithTag("EnemySpawner").transform;
        enemy = GameObject.FindWithTag("Enemy").transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 3.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void  SpawnEnemy()
    {
        Instantiate(enemy, enemySpawner.transform.position, Quaternion.identity);
    }
}
