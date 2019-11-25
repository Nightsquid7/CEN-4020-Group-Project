using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    /*
    public Dropdown reosolutionDropdown;
    Resolution[] resolutions;

    void Start()
    {
        // resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();

        // convert resolutions to strings to feed into AddOptions(), store in list
        List<string> options = new List<string>();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
        }

        // add list created above
        resolutionDropdown.AddOptions(options);
    }
    */

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("Volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen(bool isFull)
    {
        Screen.fullScreen = isFull;
    }
}
