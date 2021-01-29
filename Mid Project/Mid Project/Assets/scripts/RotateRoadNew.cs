using UnityEngine;


/*
 * Script call functions that rotate RoadPivot, as long as the sphere is on the object.
 * According to the input (arrow keys) it calls the suitable function.
 * Scripts (this and RotatePivot) are seperate because 1 is for pivot and 2 for road.
 *
 * Author: Jhonny
 * Date: 12/10/19
 * last update: -
 * By: -
 * Information updated: -
 */
public class RotateRoadNew : MonoBehaviour
{
    public GameObject pivot;
    public SphereCollider sphere;
    public Vector3 rotation;        //current rotation of object
    public Vector3 sphereCenter;
    

    /*
     * function call suitable functions to rotate.
     * sphereCenter is for knowing the position to rotate around.
     */
    void OnCollisionStay(Collision col)
    {
        rotation = transform.eulerAngles;

        if (col.collider == sphere)
        {
            sphereCenter = col.collider.attachedRigidbody.position;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                pivot.GetComponent<RotatePivot>().MoveLeft(rotation, sphereCenter);                
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                pivot.GetComponent<RotatePivot>().MoveRight(rotation, sphereCenter);                
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                pivot.GetComponent<RotatePivot>().MoveUp(rotation, sphereCenter);                
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                pivot.GetComponent<RotatePivot>().MoveDown(rotation, sphereCenter);                
            }
        }
    }
}
