using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject OptionsMenu;
    public GameObject TrailersMenu;
    public GameObject CreditsMenu;


    // Start is called before the first frame update
    void Start()
    {
        OptionsMenu.SetActive(false);
        TrailersMenu.SetActive(false);
        CreditsMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
