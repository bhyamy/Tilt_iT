using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Documentation needs to be completed.
 *
 * Author: Yam
 * Date: 11/10/19
 * last update: -
 * By: -
 * Information updated: -
 */
public class BallCollisionEvents : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject roadPivot;
    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //gives the ball the ability from the capsule
    private void OnTriggerEnter(Collider other) {
        if (other.name.StartsWith("Capsule"))
        {
            int power = ((Ability) other.GetComponent("Ability")).power;        
            /* 0 - larger ball, 1 - harder tilt, 2 - shield
                3 - easier tilt, 4 - smaller ball ......*/
            switch (power)
            {
                case 0:
                gameObject.AddComponent<LargerBall>();
                break;
                case 1:
                roadPivot.AddComponent<HarderTilt>();
                break;
                case 2:
                
                break;
                case 3:
                roadPivot.AddComponent<EasierTilt>();
                break;
                case 4:
                gameObject.AddComponent<SmallerBall>();
                break;
                default:
                break;
            }
        }
        else if (other.name.StartsWith("Coin")) {
            int power = ((Ability) other.GetComponent("Ability")).power;
            gameObject.GetComponent<ScoreTracker>().pointsEarned += power;
        }
        else if (other.name.StartsWith("Heart")) {
            int power = ((Ability) other.GetComponent("Ability")).power;
            // adds life to the player
        }
        else if (other.name.StartsWith("EndBarrier")) {
            GetComponent<Rigidbody>().isKinematic = true;
            gameObject.AddComponent<LevelEnding>();
        }
        else if (other.name.StartsWith("FallDetector")) {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
