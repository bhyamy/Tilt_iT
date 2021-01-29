using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadMenu() {
        SceneManager.LoadScene(0);
    }

    public void LoadLevel(int i) {
        SceneManager.LoadScene(i + 1);
    }
}
