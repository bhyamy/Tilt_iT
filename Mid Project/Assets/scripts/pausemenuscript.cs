using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
* Author: Iris
 */

public class pausemenuscript : MonoBehaviour
{
    public bool onSettingScreen;
    public static bool gameIsPaused;
    public GameObject pauseMenuUI;

    void Start() {
        gameIsPaused = false;
        pauseMenuUI.SetActive(false);
        onSettingScreen = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !onSettingScreen) {
            if (gameIsPaused) {
                Resume();
            } else {
                Pause();
            }
        }
    }
    
    // resumes the game when user presses escape.
    public void Resume() {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    // freeze the game when user presses escape.
    void Pause() {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    // load back the menu.
    public void LoadMenu() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void Restart() {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Settings() {
        onSettingScreen = !onSettingScreen;
    }
}
