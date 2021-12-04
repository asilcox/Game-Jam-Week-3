using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _timerText;
    [SerializeField] private int _minutes;
    [SerializeField][Range(0, 60)] private float _seconds;
    [SerializeField] private bool _isCountEnabled;

    private void Update()
    {
        if(_isCountEnabled && (_minutes > 0 || (_minutes == 0 && _seconds >= 0)))
        {
            _seconds -= Time.deltaTime;

            if(_seconds < 0 && _minutes > 0)
            {
                _seconds = 60;
                _minutes--;
            }

            _timerText.text = _seconds < 10 ? $"{_minutes}:0{(int)_seconds}" : $"{_minutes}:{(int)_seconds}";
        }
        else
        {
            if (_isCountEnabled && _minutes <= 0 && _seconds <= 0)
            {
                _isCountEnabled = false;
                Debug.Log("Times Up");
            }
        }
    }
}
