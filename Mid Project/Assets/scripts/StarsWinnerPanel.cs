using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsWinnerPanel : MonoBehaviour
{
    public GameObject ball;
    public Image firstFull;
    public Image firstEmpty;
    public Image secoundFull;
    public Image secoundEmpty;
    public Image thirdFull;
    public Image thirdEmpty;
    private ScoreTracker tracker;

    // Start is called before the first frame update
    void Start()
    {
        tracker = ball.GetComponent<ScoreTracker>();
        //sets the stars activeness
        //first
        firstEmpty.enabled = true;
        firstFull.enabled = false;
        //secound
        secoundEmpty.enabled = true;
        secoundFull.enabled = false;
        //third
        thirdEmpty.enabled = true;
        thirdFull.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        //filling the stars
        //first
        if (tracker.firstSwitch) {
            firstEmpty.enabled = false;
            firstFull.enabled = true;
        }
        //secound
        if (tracker.secoundSwitch) {
            secoundEmpty.enabled = false;
            secoundFull.enabled = true;
        }
        //third
        if (tracker.thirdSwitch) {
            thirdEmpty.enabled = false;
            thirdFull.enabled = true;
        }
    }
}
