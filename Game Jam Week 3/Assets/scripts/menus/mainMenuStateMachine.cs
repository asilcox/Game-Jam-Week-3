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

    [SerializeField] InputField sceneInputField;
    [SerializeField] mainStates currentMenuState;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(currentMenuState)
        {
            
            case mainStates.main:
                {
                    /*mainPanel.SetActive(true);
                    optionsPanel.SetActive(false);
                    creditsPanel.SetActive(false);*/

                    break;
                }
            case mainStates.options:
                {
                    /*mainPanel.SetActive(false);
                    optionsPanel.SetActive(true);
                    creditsPanel.SetActive(false);*/
                    break;
                }
            case mainStates.credits:
                {
                    /*mainPanel.SetActive(false);
                    optionsPanel.SetActive(false);
                    creditsPanel.SetActive(true);*/
                    break;
                }
        }
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void optionsPan()
    {
        currentMenuState = mainStates.options;
    }

    public void creditsPan()
    {
        currentMenuState = mainStates.credits;
    }

    public void mainPan()
    {
        currentMenuState = mainStates.main;
    }

    public void loadNamedScene(string sceneName)
    {
        StartCoroutine(LevelTransitionManager.Instance.CallScene(sceneName));
    }

    public void loadDevNamedScene()
    {
        StartCoroutine(LevelTransitionManager.Instance.CallScene(sceneInputField.text));
    }

    public void buttonDebugger()
    {
        Debug.Log("Clicker");
    }


    public enum mainStates
    {
        main,
        options,
        credits,


    }
}
