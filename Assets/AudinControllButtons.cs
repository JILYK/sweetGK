using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudinControllButtons : MonoBehaviour
{
    public List<GameObject> turnOffButtons;
    public List<GameObject> turnOnButtons;

    public AudioSource audioSource;

    public void turnOffAudio()
    {
        audioSource.enabled = true;

        foreach (var btn in turnOnButtons)
        {
            btn.SetActive(true);
        }
        foreach (var btn in turnOffButtons)
        {
            btn.SetActive(false);
        }
        audioSource.Play();
    }

    public void turnOnAudio()
    {
        audioSource.enabled = false;

        foreach (var btn in turnOffButtons)
        {
            btn.SetActive(true);
        }
        foreach (var btn in turnOnButtons)
        {
            btn.SetActive(false);
        }
        audioSource.Pause();
    }
}