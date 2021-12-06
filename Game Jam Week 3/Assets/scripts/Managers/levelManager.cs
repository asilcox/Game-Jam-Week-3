using TMPro;
using UnityEngine;
public class levelManager : MonoBehaviour
{
    [Header("Popcorn Values")]
    [SerializeField] int popcornRemaining;
    [SerializeField] int popcornCollected;

    [Header("Timer Values")]
    [SerializeField] float secondsRemaining;
    [SerializeField] int minutesRemaining;

    [Header("Text Values")]
    [SerializeField] TextMeshProUGUI popcornRemText;
    [SerializeField] TextMeshProUGUI popcornColText;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] TextMeshProUGUI livesText;

    [Header("Win and Lose panels")]
    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject losePanel;
    [SerializeField] GameObject bigLosePanel;

    private void Awake()
    {
        Time.timeScale = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        popcornRemaining = GameObject.FindObjectsOfType<popcornInteractable>().Length;
    }

    // Update is called once per frame
    void Update()
    {
        //Text settings
        popcornRemText.text = " Popcorn remaining: " + popcornRemaining.ToString();
        popcornColText.text = " Popcorn Collected " + popcornCollected.ToString();
        livesText.text = " Lives: " + PlayerPrefs.GetInt("playerLives").ToString();

        if (secondsRemaining < 10)
        {
            timerText.text = "Time Remaining: " + minutesRemaining.ToString() + " : " + secondsRemaining.ToString("f1");
        }
        else
        {
            timerText.text = "Time Remaining: " + minutesRemaining.ToString() + " : " + secondsRemaining.ToString("f0");
        }



        //Timer
        secondsRemaining = secondsRemaining - 1 * Time.deltaTime;

        if (secondsRemaining <= 0 && minutesRemaining >= 1)
        {
            secondsRemaining = 60;
            minutesRemaining--;
        }

        if (secondsRemaining <= 0 && minutesRemaining <= 0)
        {
            loseGame();
        }

        //WinConditions
        if (popcornRemaining <= 0 && secondsRemaining >= 1)
        {
            winGame();
        }

    }

    public void collectPopcorn()
    {
        popcornCollected++;
        popcornRemaining--;
    }

    public void loseGame()
    {
        if (PlayerPrefs.GetInt("playerLives") <= 0)
        {
            bigLosePanel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            losePanel.SetActive(true);
            Time.timeScale = 0;
        }


    }

    public void winGame()
    {
        winPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
