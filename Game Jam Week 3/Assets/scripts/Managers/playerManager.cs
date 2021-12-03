using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playerManager : MonoBehaviour
{
    [SerializeField] livesManager lManager;
    // Start is called before the first frame update
    void Start()
    {
        lManager = GameObject.FindObjectOfType<livesManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            lManager.loseLife();
            
        }
    }
}
