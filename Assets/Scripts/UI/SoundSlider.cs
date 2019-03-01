﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSlider : MonoBehaviour
{

    public Text soundText;
    public string settingsKey;

    Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>(); // Get Slider Object
        LoadSettings(); // Load Settings from PlayerPrefas
        slider.onValueChanged.AddListener(delegate { SetValue(); }); // Add listener to change value
    }

    void LoadSettings()
    {
        if (PlayerPrefs.HasKey(settingsKey))
        {
            slider.value = PlayerPrefs.GetFloat(settingsKey);
        }
        else
        {
            slider.value = 0.5f;
        }

        soundText.text = Mathf.Round(slider.value * 100f).ToString() + "%";
    }

    void SaveSettings()
    {
        PlayerPrefs.SetFloat(settingsKey, slider.value);
    }

    void SetValue()
    {
        soundText.text = Mathf.Round(slider.value * 100f).ToString() + "%";
        SaveSettings();
    }
}
