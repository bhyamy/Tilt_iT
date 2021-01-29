using UnityEngine;
using UnityEngine.UI;


/*
 * Script update the text in GameObject "ScoreText".
 * The variable "score" in this script is updated from "ScoreTracker" script.
 *
 * Author: Yehonatan Sofri
 * Date: 8/10/19
 * last update: 15/10/10
 * By: Jhonny
 * Information updated: Adding "Score: " string in update.
 */
public class ScoreDisplay : MonoBehaviour
{
    
    
    public Text   scoreText; // Text object is the ScoreText instance in the canvas
    public Slider scoreBar;  // this variable is updated from "ScoreTracker" script

    
    /*
     * Update the text in ScoreText GameObject.
     */
    void Update()
    {
        if (scoreBar != null) {
            scoreText.text = scoreBar.value.ToString();
        }
        
    }
}