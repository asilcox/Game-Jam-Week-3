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

    
    public float coolDownBarricade = 5.0f;
    public float coolDownTurret = 15.0f;
    public float useSkillTimeBarricade;
    public float useSkillTimeTurret;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;


        if (Time.time > useSkillTimeBarricade)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {

                //if()

                //{
                Instantiate(barricade, new Vector3(playerPos.x, playerPos.y, playerPos.z + 2), Quaternion.AngleAxis(180, Vector3.up));
                useSkillTimeBarricade = Time.time + coolDownBarricade;
                //}

            }
        }

        if (Time.time > useSkillTimeTurret)
        {

            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Instantiate(turret, new Vector3(playerPos.x, playerPos.y, playerPos.z + 2), Quaternion.AngleAxis(180, Vector3.up));
                useSkillTimeTurret = Time.time + coolDownTurret;
            }
        }
    }
}
