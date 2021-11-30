using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuLightsForFun : MonoBehaviour
{
    [SerializeField] bool isLit;
    [SerializeField] Image imgLight;
    // Start is called before the first frame update
    void Start()
    {
        isLit = true;
        imgLight.color = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activateLight()
    {
        if(isLit == true)
        {
            isLit = false;
            imgLight.color = Color.black;
        }
        else
        {
            isLit = true;
            imgLight.color = Color.yellow;
        }
    }
}
