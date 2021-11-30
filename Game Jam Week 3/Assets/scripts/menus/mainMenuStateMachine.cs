using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenuStateMachine : MonoBehaviour
{
    [Header("Menu Panels")]
    [SerializeField] GameObject mainPanel;
    [SerializeField] GameObject optionsPanel;
    [SerializeField] GameObject creditsPanel;
    [SerializeField] GameObject sceneNamePanel;

    [SerializeField] InputField sceneInputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadNamedScene()
    {

    }

    public void loadDevNamedScene()
    {

    }


    public enum mainStates
    {
        introMain,
        devSceneNamePanelState,
        main,
        options,
        credits,


    }
}
