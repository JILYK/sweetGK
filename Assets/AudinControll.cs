using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudinControll : MonoBehaviour
{
    public Slider slider;
    public Slider slider_2;

   
    public AudioSource AudioListener;
    public void controllLisener()
    {

        if (slider.value == slider.maxValue)
        {
            AudioListener.Play();
        }
        else AudioListener.Pause();

    }
    public void controllLisener2()
    {

        if (slider_2.value == slider_2.maxValue)
        {
            AudioListener.enabled = true;
        }
        else AudioListener.enabled = false;

    }
}
