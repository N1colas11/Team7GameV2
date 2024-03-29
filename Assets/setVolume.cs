﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class setVolume : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider slider;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("MusicVolume", 0.75f);
    }

    public void SetLevel()
    {
        float sliderValue = slider.value;
        mixer.SetFloat("MusicVol", sliderValue);
        PlayerPrefs.SetFloat("MusicVolume", sliderValue);
    }
}