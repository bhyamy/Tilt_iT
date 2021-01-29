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
public class Ability : MonoBehaviour
{
    /* 0 - larger ball, 1 - harder tilt, 2 - shield
        3 - easier tilt, 4 - smaller ball ......*/
    public int power;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // destroy the capsole on collision, ***THE NAME OF THE BALL MIGHT BE WRONG
    private void OnTriggerEnter(Collider other) {
        if (other.name.Equals("Ball"))
         {
            Destroy(gameObject); 
         }
    }

    
}
