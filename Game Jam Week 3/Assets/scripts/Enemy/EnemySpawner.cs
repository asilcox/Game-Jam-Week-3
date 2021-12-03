using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemySpawner;
    [SerializeField]
    private GameObject enemy;

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
