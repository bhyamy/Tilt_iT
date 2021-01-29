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
public class SmallerBall : MonoBehaviour
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
        // making the ball half of the original Size
        transform.localScale = originalSize * 0.5f;
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
