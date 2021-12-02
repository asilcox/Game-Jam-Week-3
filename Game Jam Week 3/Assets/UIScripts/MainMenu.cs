using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public GameObject OptionsMenu;
    public GameObject TrailersMenu;
    public GameObject CreditsMenu;
    public GameObject QuitMenuPopUp;


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

    public void TrailerOne()
    {
        SceneManager.LoadScene("Trailer 1");
    }

    public void TrailerTwo()
    {
        SceneManager.LoadScene("Trailer 2");
    }

    public void TrailerThree()
    {
        SceneManager.LoadScene("Trailer 3");
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
