using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popcornInteractable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //insert call to HUD and popcorn totals for level here
            Debug.Log("Popcorn picked up");
            Destroy(this.gameObject);
        }
    }
}
