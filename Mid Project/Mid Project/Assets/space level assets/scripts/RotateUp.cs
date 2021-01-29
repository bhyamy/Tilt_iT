using UnityEngine;


/*
 * Rotate the transform around pivot.
 * Variables are modified through the inspector, each object has it's one specifics.
 *
 * Author: Jhonny
 * Date: 14/10/19
 * last update: -
 * By: -
 * Information updated: -
 */
public class RotateUp : MonoBehaviour
{
   
   
    public GameObject pivot;
    public float      turnSpeed;


    void Update()
    {
        transform.RotateAround(pivot.transform.position, Vector3.up, turnSpeed * Time.deltaTime);
    }
}
