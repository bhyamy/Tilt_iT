using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsPanel : MonoBehaviour
{
    public Slider scoreBar;
    public GameObject ball;
    public Image firstMark;
    public Image firstFull;
    public Image firstEmpty;
    public Image secoundMark;
    public Image secoundFull;
    public Image secoundEmpty;
    public Image thirdMark;
    public Image thirdFull;
    public Image thirdEmpty;
    private ScoreTracker tracker;

    // Start is called before the first frame update
    void Start()
    {
        float sliderWidth = scoreBar.GetComponent<RectTransform>().rect.width;
        tracker = ball.GetComponent<ScoreTracker>();
        //putting the stars and marks in their X locations
        //first star
        firstMark.rectTransform.anchoredPosition = new Vector2((-sliderWidth / 2) + (sliderWidth * (tracker.pointsToFirst / tracker.maxPoints)), 0);
        firstEmpty.rectTransform.anchoredPosition = new Vector2((-sliderWidth / 2) + (sliderWidth * (tracker.pointsToFirst / tracker.maxPoints)), -50);
        firstFull.rectTransform.anchoredPosition = new Vector2((-sliderWidth / 2) + (sliderWidth * (tracker.pointsToFirst / tracker.maxPoints)), -50);
        //secound star
        secoundMark.rectTransform.anchoredPosition = new Vector2((-sliderWidth / 2) + (sliderWidth * (tracker.pointsToSecond / tracker.maxPoints)), 0);
        secoundEmpty.rectTransform.anchoredPosition = new Vector2((-sliderWidth / 2) + (sliderWidth * (tracker.pointsToSecond / tracker.maxPoints)), -50);
        secoundFull.rectTransform.anchoredPosition = new Vector2((-sliderWidth / 2) + (sliderWidth * (tracker.pointsToSecond / tracker.maxPoints)), -50);
        //third star
        thirdMark.rectTransform.anchoredPosition = new Vector2((-sliderWidth / 2) + (sliderWidth * (tracker.pointsToThird / tracker.maxPoints)), 0);
        thirdEmpty.rectTransform.anchoredPosition = new Vector2((-sliderWidth / 2) + (sliderWidth * (tracker.pointsToThird / tracker.maxPoints)), -50);
        thirdFull.rectTransform.anchoredPosition = new Vector2((-sliderWidth / 2) + (sliderWidth * (tracker.pointsToThird / tracker.maxPoints)), -50);

        //sets the stars activeness
        //first
        firstMark.enabled = true;
        firstEmpty.enabled = true;
        firstFull.enabled = false;
        //secound
        secoundMark.enabled = true;
        secoundEmpty.enabled = true;
        secoundFull.enabled = false;
        //third
        thirdMark.enabled = true;
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
