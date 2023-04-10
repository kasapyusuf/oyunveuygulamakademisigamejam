using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    [SerializeField]
    private float timeValue = 181f;
    [SerializeField]
    private AudioClip clockClip, bellClip;

    private bool clockPlaying = true;
    private bool bellPlaying = true;

    public TextMeshProUGUI timeText;

    AudioSource[] _audios = new AudioSource[2];

    private void Start()
    {
        _audios= gameObject.GetComponents<AudioSource>();
    }

    private void Update()
    {
        TimeandSound();
        DisplayTime(timeValue);      
    }

    void TimeandSound()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;

            if (timeValue <= 11 && timeValue >= 1 && clockPlaying)
            {
                _audios[0].PlayOneShot(clockClip);
                clockPlaying = false;
            }
            else if (timeValue < 1 && timeValue > 0 && bellPlaying)
            {
                _audios[0].PlayOneShot(bellClip);
                bellPlaying = false;
            }
        }
        else
        {
            timeValue = 0;
            clockPlaying = true;
            bellPlaying = true;
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
            Invoke("EndGame", 1f);          
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{00:00}:{01:00}", minutes, seconds);
    }

    //Kaybetme gibi bir sahne daha yapýlýrsa o sahneye de atýlabilir.
    public void EndGame()
    {
        SceneManager.LoadScene("Start");
    }




}
