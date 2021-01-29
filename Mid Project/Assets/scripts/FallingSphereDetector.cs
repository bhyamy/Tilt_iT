using UnityEngine;

/*
 * Documentation need to be completed.
 *
 * Author: Yehonatan Sofri
 * Date: 8/10/19
 * last update: 11/10/19
 * By: Yam
 * Information updated: changed the name Sphere th Ball
 */
public class FallingSphereDetector : MonoBehaviour
{


    /*
     * Called when a collider falls on the plane.
     * if the collider is the sphere, sends a message to console - 
     */
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == GameObject.Find("Ball"))
        {
            Debug.Log("The Ball Fell");
        }
    }
}
