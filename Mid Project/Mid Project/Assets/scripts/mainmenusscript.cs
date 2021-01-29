using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
* Author: Iris
 */

public class mainmenusscript : MonoBehaviour
{
    // runs the first level when user presses Start game button.
      public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame() {
      // exits game when user presses Quit button.
      Application.Quit();
    }
}
