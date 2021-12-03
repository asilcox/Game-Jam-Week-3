using UnityEngine;
using UnityEngine.SceneManagement;

public class livesManager : MonoBehaviour
{
    public int livesRemaining;

    // Start is called before the first frame update
    void Start()
    {
        livesRemaining = PlayerPrefs.GetInt("playerLives");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loseLife()
    {
        livesRemaining--;

        if (livesRemaining < 1)
        {
            
            SceneManager.LoadScene("MainMenu");
        }
        else
        {
            var sceneName = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(sceneName);
            PlayerPrefs.SetInt("playerLives", livesRemaining);
        }


    }
}
