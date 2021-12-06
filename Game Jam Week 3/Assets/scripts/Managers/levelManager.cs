using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class levelManager : MonoBehaviour
{
    [Header("Popcorn Values")]
    [SerializeField] int popcornRemaining;
    [SerializeField] int popcornCollected;

    [Header("Timer Values")]
    [SerializeField] float maxTime;
    [SerializeField] float secondsRemaining;
    [SerializeField] int minutesRemaining;

    [Header("Text Values")]
    [SerializeField] TextMeshProUGUI popcornRemText;
    [SerializeField] TextMeshProUGUI popcornColText;
    [SerializeField] TextMeshProUGUI timerText;

    [Header("Win and Lose panels")]
    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject losePanel;
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
        timerText.text = "Time Remaining: " + minutesRemaining.ToString() + " : " + secondsRemaining.ToString("f0");

        //Timer
        secondsRemaining = secondsRemaining - 1 * Time.deltaTime;

        if(secondsRemaining <= 0 && minutesRemaining >= 1)
        {
            secondsRemaining = 60;
            minutesRemaining--;
        }

        if(secondsRemaining <= 0 && minutesRemaining <= 0)
        {

        }

        //WinConditions
        if(popcornRemaining <= 0 && secondsRemaining >= 1)
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
        losePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void winGame()
    {
        winPanel.SetActive(true);
        Time.timeScale = 0;
    }
}
