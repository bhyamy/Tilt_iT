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
 // THIS CODE IS ONLY A PLATE!! DO NOT ADD TO ANY OBJECT!
public class AbilityScriptPlate : MonoBehaviour
{
    public float countFrom;
    public float timer;
    private float timeFlag;
    // Start is called before the first frame update
    void Start()
    {
        timeFlag = Time.time;
        timer = countFrom;
        // Enter the ability
    }

    // Update is called once per frame
    void Update()
    {
        timer -= (Time.time - timeFlag);
        timeFlag = Time.time;
        if (timer <= 0) {
            // Cancel the ability before the script is destroyed

            Destroy(this);
        }
    }
}
