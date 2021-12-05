using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestruction : MonoBehaviour
{
    public GameObject _enemy;

    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            _enemy = other.gameObject;
            _enemy.GetComponent<EnemyHealth>().TakeDamage(damage);
        }
    }
}
