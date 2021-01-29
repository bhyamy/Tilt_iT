using UnityEngine;


/*
 * Rotate the earth around it's center.
 *
 * Author: Jhonny
 * Date: 14/10/19
 * last update: -
 * By: -
 * Information updated: -
 */
public class RotateEarth : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.5f, 0.5f, 0f);   
    }
}
