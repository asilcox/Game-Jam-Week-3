using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerSkills : MonoBehaviour
{
    public GameObject player;
    public GameObject barricade;
    public GameObject turret;
    public Vector3 playerPos;
    public Vector3 playerOffset;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // barricade.transform.position= player.transform.position;
        //barricade.transform.eulerAngles = player.transform.eulerAngles;
        playerPos = player.transform.position;
        


        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Instantiate(barricade, transform.TransformPoint(Vector3.right*2), transform.rotation);
           //Instantiate(barricade, player.transform.position + player.transform.forward + Vector3.right * 1, player.transform.rotation);
           
            //if()
            
            //{
                Instantiate(barricade, new Vector3(playerPos.x, playerPos.y, playerPos.z + 2), Quaternion.AngleAxis(180, Vector3.up)); 
            //}

        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Instantiate(turret, transform.position + (transform.right*-4), transform.rotation);
        }
    }
}
