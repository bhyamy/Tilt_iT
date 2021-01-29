using UnityEngine;
using UnityEngine.UI;


/*
 * Script update the score in the game, by the position of the sphere.
 * The script also updates the "ScoreText" GameObject.
 *
 * Author: Yehonatan Sofri
 * Date: 8/10/19
 * last update: 10/10/19
 * By: Yam
 * Information updated: added variable 'pointsEarned' and edited
 * the information that is sent to the 'ScoreText'
 */
public class ScoreTracker : MonoBehaviour
{
    private float startPosition;
    public Transform sphere;
    public int       score;
    public float     currentPosition;  //position of the sphere
    public int pointsEarned = 0; // points from collecting coins
    public Slider scoreBar; // don't forget th attach the score bar
    public float pointsToFirst; // the amount of points for the first star
    public float pointsToSecond; // the amount of points for the Second star
    public float pointsToThird; // the amount of points for the Third star
    public float maxPoints; // the maximum amount of points
    public bool firstSwitch;
    public bool secoundSwitch;
    public bool thirdSwitch;

void Start() {
    scoreBar.maxValue = maxPoints;
    startPosition = sphere.position.x;
    firstSwitch = false;
    secoundSwitch = false;
    thirdSwitch = false;
}
    
    
    /*
     * The score is determined by the x axis of the sphere position.
     * It is set by the farthest point in which the sphere has got so far.
     * Therefore, the score can only go up.
     * Function also update the score variable in ScoreDisplay script.
     */
    void Update()
    {
       currentPosition = sphere.position.x;
       
        if ((int) currentPosition > score)
        {
            score = (int) (sphere.position.x - startPosition);
        }
        scoreBar.value = score + pointsEarned;

        if (scoreBar.value >= pointsToFirst) firstSwitch = true;
        if (scoreBar.value >= pointsToSecond) secoundSwitch = true;
        if (scoreBar.value >= pointsToThird) thirdSwitch = true;
    }
}
