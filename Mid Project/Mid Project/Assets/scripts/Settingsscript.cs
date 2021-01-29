using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

/*
* Author: Iris
 */

public class Settingsscript : MonoBehaviour
{
  public AudioMixer audioMixer;
  Resolution[] resolutions;

  public Dropdown resolutionDropdown;
  public Dropdown qualityDropdown;
  public Slider volumeBar;
  void Start() {
    //receive the resolutions available in the user's computer,also edited the settings so
    //only 16:9 resolutions will be optional.
    resolutions = Screen.resolutions;
    resolutionDropdown.ClearOptions();
    List<string> options = new List<string>();
    int currentResolutionIndex = 0;
    for (int i = 0; i < resolutions.Length; i++) {
      string option = resolutions[i].width + " x " + resolutions[i].height;
      options.Add(option);
      //check the best resolution in the user's computer
      if ((resolutions[i].width == Screen.width) && (resolutions[i].height == Screen.height)) {
        Debug.Log(i);
        currentResolutionIndex = i;
      }
    }
    resolutionDropdown.AddOptions(options);
    resolutionDropdown.value = currentResolutionIndex;
    resolutionDropdown.RefreshShownValue();
    //Quality
    qualityDropdown.value = QualitySettings.GetQualityLevel();
    // volume
  }

  //enables the user to choose resolution.
public void SetResolution(int resolutionIndex) {
  Resolution resolution = resolutions[resolutionIndex];
  Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
}

  // enables to increase/decrease the volume of the volume slider.
  public void SetVolume(float vol) {
    audioMixer.SetFloat("volume", vol);
  }
  
  //enables to control the quality of the game, user can choose.
  public void SetQuality(int qualityIndex) {
    QualitySettings.SetQualityLevel(qualityIndex);
  }

  //enables the user to choose whether the screen is full or not.
  public void SetFullscreen(bool isScreenFull) {
    Screen.fullScreen = isScreenFull;
  }
}



