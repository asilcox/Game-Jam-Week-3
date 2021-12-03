using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemySpawner;

    [SerializeField]
    private float enemySpawnTimer = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(enemySpawnTimer, enemySpawner));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawnEnemy(float spawner, GameObject enemy)
    {
        yield return  new WaitForSeconds(spawner);
        GameObject newEnemy = Instantiate(enemy);
        StartCoroutine(spawnEnemy(spawner, enemy));
    }
}
