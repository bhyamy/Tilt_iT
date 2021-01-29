using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: Yam
 * Date: 11/10/19
 * last update: -
 * By: -
 * Information updated: -
 */
public class HarderTilt : MonoBehaviour
{
    public float countFrom = 10;
    public float timer;
    private float timeFlag;
    public float originalTurnSpeed;
    // Start is called before the first frame update
    void Awake() {
        originalTurnSpeed = gameObject.GetComponent<RotateRoad>().turnSpeed;
    }
    void Start()
    {
        timeFlag = Time.time;
        timer = countFrom;
        // Enter the ability
        gameObject.GetComponent<RotateRoad>().turnSpeed = 2 * originalTurnSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= (Time.time - timeFlag);
        timeFlag = Time.time;
        if (timer <= 0) {
            // Cancel the ability before the script is destroyed
            gameObject.GetComponent<RotateRoad>().turnSpeed = originalTurnSpeed;
            Destroy(this);
        }
    }
}
