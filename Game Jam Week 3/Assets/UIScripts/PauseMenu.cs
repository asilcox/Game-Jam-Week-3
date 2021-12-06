using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuUI;
    public GameObject OptionsMenu;
    public GameObject Confirmation;
    public AudioSource OpenMenu;
    public AudioSource CloseMenu;

    [SerializeField] string nextlevel;
    public static bool GameisPaused = false;

    void start()
    {
        Time.timeScale = 1f;
        OptionsMenu.SetActive(false);
        PauseMenuUI.SetActive(false);
}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }


    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameisPaused = false;
        CloseMenu.Play();
    }

    public void winGameAdvance()
    {
        SceneManager.LoadScene(nextlevel);
    }

    void Pause()
    {

        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameisPaused = true;
        OpenMenu.Play();
    }

    public void OpenOptionsMenu()
    {
        if (OptionsMenu != null)
        {
            bool isActive = OptionsMenu.activeSelf;

            OptionsMenu.SetActive(!isActive);
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ConfirmQuit()
    {
        if (Confirmation != null)
        {
            bool isActive = Confirmation.activeSelf;

            Confirmation.SetActive(!isActive);
        }
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("ThisLevel");
        Debug.Log("Replaying Level...");
    }

}

