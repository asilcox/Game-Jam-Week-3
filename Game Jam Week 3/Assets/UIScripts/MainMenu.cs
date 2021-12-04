using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour
{

    public GameObject OptionsMenu;
    public GameObject TrailersMenu;
    public GameObject CreditsMenu;
    public GameObject QuitMenuPopUp;
    public GameObject namePanel;
    [SerializeField] TMP_InputField nameField;

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetString("playerName") == "")
        {
            namePanel.SetActive(true);
        }
        else
        {
            namePanel.SetActive(false);
        }
        OptionsMenu.SetActive(false);
        TrailersMenu.SetActive(false);
        CreditsMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setPlayerName()
    {
        PlayerPrefs.SetString("playerName", nameField.ToString());
        namePanel.SetActive(false);
    }

    public void PlayGame()
    {
        Debug.Log("LoadingGame...");

        SceneManager.LoadScene("SampleScene");
    }

    public void Trailers()
    {
        if (TrailersMenu != null)
        {
            bool isActive = TrailersMenu.activeSelf;

            TrailersMenu.SetActive(!isActive);
        }
    }

    public void resetKeys()
    {
        PlayerPrefs.DeleteAll();
    }

    public void OpenOptionsMenu()
    {
        if (OptionsMenu != null)
        {
            bool isActive = OptionsMenu.activeSelf;

            OptionsMenu.SetActive(!isActive);
        }
    }

    public void Credits()
    {
        if (CreditsMenu != null)
        {
            bool isActive = CreditsMenu.activeSelf;

            CreditsMenu.SetActive(!isActive);
        }
    }

    public void Quit()
    {

       Application.Quit();
    }

    public void TrailerOne()
    {
        SceneManager.LoadScene("ZomLevel");
    }

    public void TrailerTwo()
    {
        SceneManager.LoadScene("spyLevel");
    }

    public void TrailerThree()
    {
        SceneManager.LoadScene("romComLevel");
    }
    public void QuitConfirm()
    {
        if (QuitMenuPopUp != null)
        {
            bool isActive = QuitMenuPopUp.activeSelf;

            QuitMenuPopUp.SetActive(!isActive);
        }
    }
}
