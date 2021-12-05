using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerSkills : MonoBehaviour
{
    public GameObject player;
    public GameObject barricade;
    public GameObject turret;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(barricade, transform.position+(transform.right*-2), transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(turret, transform.position + (transform.right*-4), transform.rotation);
        }
    }
}
