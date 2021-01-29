// written by Yam

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
public class LargerBall : MonoBehaviour
{
    public float countfrom = 10;
    public float timer;
    private float timeFlag;
    private Vector3 originalSize = Vector3.one;
    // Start is called before the first frame update
    void Start()
    {
        timeFlag = Time.time;
        timer = countfrom;
        // doubling the Size
        transform.localScale = 2 * originalSize;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= (Time.time - timeFlag);
        timeFlag = Time.time;
        if (timer <= 0) {
            // Cancel the ability before the script is destroyed
            transform.localScale = originalSize;
            Destroy(this);
        }
    }
}
