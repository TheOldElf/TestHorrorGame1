using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;

public class settings : MonoBehaviour
{
    public Dropdown graphicsDropdown, resolutionDropdown;
    public Slider volumeSlider;
    public Toggle vignetteToggle, chromaticToggle, grainToggle;
    public bool inGame;
    public GameObject chromaticCam, vignetteCam, grainCam;

    void Start()
    {
        //Standart graph settings
        if (PlayerPrefs.GetInt("settingsSaved", 0) == 0)
        {
            PlayerPrefs.SetInt("graphics", 0);
            PlayerPrefs.SetInt("resolution", 0);
            PlayerPrefs.SetFloat("mastervolume", 1.0f);
            PlayerPrefs.SetInt("vignette", 0);
            PlayerPrefs.SetInt("chromatic", 0);
            PlayerPrefs.SetInt("grain", 0);
        }

        //graphics quality change
        if (PlayerPrefs.GetInt("graphics", 2) == 2)
        {
            graphicsDropdown.value = 0;
            QualitySettings.SetQualityLevel(0);
        }
        if (PlayerPrefs.GetInt("graphics", 1) == 1)
        {
            graphicsDropdown.value = 1;
            QualitySettings.SetQualityLevel(1);
        }
        if (PlayerPrefs.GetInt("graphics", 0) == 0)
        {
            graphicsDropdown.value = 2;
            QualitySettings.SetQualityLevel(2);
        }

        //resolution change
        if(PlayerPrefs.GetInt("resolution", 2) == 2)
        {
            resolutionDropdown.value = 2;
            Screen.SetResolution(854, 480, true);
        }
        if (PlayerPrefs.GetInt("resolution", 1) == 1)
        {
            resolutionDropdown.value = 1;
            Screen.SetResolution(1280, 720, true);
        }
        if (PlayerPrefs.GetInt("resolution", 0) == 0)
        {
            resolutionDropdown.value = 0;
            Screen.SetResolution(1920, 1080, true);
        }

        //volume
        volumeSlider.value = PlayerPrefs.GetFloat("mastervolume");
        AudioListener.volume = PlayerPrefs.GetFloat("mastervolume");

        //vignette
        if (PlayerPrefs.GetInt("vignette", 1) == 1)
        {
            vignetteToggle.isOn = false;
            if (inGame == true)
            {
                vignetteCam.SetActive(false);
            }
        }
        if (PlayerPrefs.GetInt("vignette", 0) == 0)
        {
            vignetteToggle.isOn = true;
            if (inGame == true)
            {
                vignetteCam.SetActive(true);
            }
        }

        //chromatic aberration
        if (PlayerPrefs.GetInt("chromatic", 1) == 1)
        {
            chromaticToggle.isOn = false;
            if (inGame == true)
            {
                chromaticCam.SetActive(false);
            }
        }
        if (PlayerPrefs.GetInt("chromatic", 0) == 0)
        {
            chromaticToggle.isOn = true;
            if (inGame == true)
            {
                chromaticCam.SetActive(true);
            }
        }

        //grain
        if (PlayerPrefs.GetInt("grain", 1) == 1)
        {
            grainToggle.isOn = false;
            if (inGame == true)
            {
                grainCam.SetActive(false);
            }
        }
        if (PlayerPrefs.GetInt("grain", 0) == 0)
        {
            grainToggle.isOn = true;
            if (inGame == true)
            {
                grainCam.SetActive(true);
            }
        }
    }

    public void setGraphics()
    {
        if (graphicsDropdown.value == 0)
        {
            PlayerPrefs.SetInt("graphics", 2);
            PlayerPrefs.Save();
            QualitySettings.SetQualityLevel(0);
        }
        if (graphicsDropdown.value == 1)
        {
            PlayerPrefs.SetInt("graphics", 1);
            PlayerPrefs.Save();
            QualitySettings.SetQualityLevel(1);
        }
        if (graphicsDropdown.value == 2)
        {
            PlayerPrefs.SetInt("graphics", 0);
            PlayerPrefs.Save();
            QualitySettings.SetQualityLevel(2);
        }
    }

    public void setResolution()
    {
        if (resolutionDropdown.value == 0)
        {
            PlayerPrefs.SetInt("resolution", 2);
            PlayerPrefs.Save();
            Screen.SetResolution(854, 480, true);
            Debug.Log("480 set");
        }
        if (resolutionDropdown.value == 0)
        {
            PlayerPrefs.SetInt("resolution", 1);
            PlayerPrefs.Save();
            Screen.SetResolution(1280, 720, true);
            Debug.Log("720 set");
        }
        if (resolutionDropdown.value == 0)
        {
            PlayerPrefs.SetInt("resolution", 0);
            PlayerPrefs.Save();
            Screen.SetResolution(1920, 1080, true);
            Debug.Log("1080 set");
        }
    }

    public void setVolume()
    {
        PlayerPrefs.SetFloat("mastervolume", volumeSlider.value);
        PlayerPrefs.Save();
        AudioListener.volume = volumeSlider.value;
    }

    public void toggleChromatic()
    {
        if (chromaticToggle.isOn == false)
        {
            PlayerPrefs.SetInt("chromatic", 1);
            PlayerPrefs.Save();
            if (inGame == true)
            {
                chromaticCam.SetActive(false);
            }
        }
        if (chromaticToggle.isOn == true)
        {
            PlayerPrefs.SetInt("chromatic", 0);
            PlayerPrefs.Save();
            if (inGame == true)
            {
                chromaticCam.SetActive(true);
            }
        }
    }

    public void toggleVignette()
    {
        if (vignetteToggle.isOn == false)
        {
            PlayerPrefs.SetInt("vignette", 1);
            PlayerPrefs.Save();
            if (inGame == true)
            {
                vignetteCam.SetActive(false);
            }
        }
        if (vignetteToggle.isOn == true)
        {
            PlayerPrefs.SetInt("vignette", 0);
            PlayerPrefs.Save();
            if (inGame == true)
            {
                vignetteCam.SetActive(true);
            }
        }
    }

    public void toggleGrain()
    {
        if (grainToggle.isOn == false)
        {
            PlayerPrefs.SetInt("grain", 1);
            PlayerPrefs.Save();
            if (inGame == true)
            {
                grainCam.SetActive(false);
            }
        }
        if (grainToggle.isOn == true)
        {
            PlayerPrefs.SetInt("grain", 0);
            PlayerPrefs.Save();
            if (inGame == true)
            {
                grainCam.SetActive(true);
            }
        }
    }

    public void saveSettings()
    {
        PlayerPrefs.SetInt("settingsSaved", 1);
        PlayerPrefs.Save();
    }
}
