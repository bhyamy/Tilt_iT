using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Script controls the Main camera's position to always follow the sphere.
 * IMPORTATNT - remember to set the variable 'sphere' in the inspector window.
 * 
 * Author: Yehonatan Sofri
 * Date: 7/10/19
 * last update: 14/10/19
 * By: Yam
 * Information updated: edited to gameStart script which moves the camera the starts the game
 */
public class GameStart : MonoBehaviour
{
    public bool readyForPlay;
    public Vector3 cameraStartingPoint;
    public float movingSpeed;
    public Vector3 cameraStartingRotation;
    public float rotationSpeed;
    private Quaternion rotation;
    public GameObject ball;       //ball to follow
    public Vector3   offset;      //to keep fixed distance from sphere
    private bool doOneTime;
    

    // Start is called before the first frame update
    void Start()
    {
        readyForPlay = false;
        Time.timeScale = 0f;
        doOneTime = true;
        ball.GetComponent<Rigidbody>().isKinematic = true;
        rotation = Quaternion.Euler(cameraStartingRotation.x, cameraStartingRotation.y, cameraStartingRotation.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (!pausemenuscript.gameIsPaused) {
            if (readyForPlay) {
            if (doOneTime) {
                offset = transform.position - ball.transform.position;
                ball.GetComponent<Rigidbody>().isKinematic = false;
                Time.timeScale = 1f;
                // add deactivating stage screen
                doOneTime = false;
            } else {
                transform.position = ball.transform.position + offset;
            }
            
        } else {
            transform.position = Vector3.MoveTowards(transform.position, cameraStartingPoint, movingSpeed);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotationSpeed);
            if (transform.position == cameraStartingPoint && transform.rotation == rotation) readyForPlay = true;
        }
        }
    }
}
