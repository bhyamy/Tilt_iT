using UnityEngine;


/*
 * Rotate the transform around a pivot.
 * Variables are modified through the inspector, each object has it's one specifics
 *
 * Author: Jhonny
 * Date: 14/10/19
 * last update: -
 * By: -
 * Information updated: -
 */
public class RotateLeft : MonoBehaviour
{

    public GameObject pivot;
    public float      turnSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(pivot.transform.position, Vector3.left, turnSpeed * Time.deltaTime);
    }
}