using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Holder : MonoBehaviour
{
    public GameObject levelWon;
    public GameObject scoreBar;
    public AudioSource music;
    // Start is called before the first frame update
    void Start()
    {
        levelWon.SetActive(false);
        scoreBar.SetActive(true);
        music = Camera.main.GetComponent<AudioSource>();
        music.enabled = true;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
