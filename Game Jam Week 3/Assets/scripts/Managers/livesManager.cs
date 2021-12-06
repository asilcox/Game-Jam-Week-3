using UnityEngine;
using UnityEngine.SceneManagement;

public class livesManager : MonoBehaviour
{
    public int livesRemaining;
    private levelManager levelMan;
    // Start is called before the first frame update
    void Start()
    {
        levelMan = GameObject.FindObjectOfType<levelManager>();
        livesRemaining = PlayerPrefs.GetInt("playerLives");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loseLife()
    {
        livesRemaining--;
        PlayerPrefs.SetInt("playerLives", livesRemaining);
        levelMan.loseGame();


    }
}
