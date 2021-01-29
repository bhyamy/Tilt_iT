using UnityEngine;


/*
 * Script contain functions to rotate object around a given point.
 * each function check that the rotation is in the limits of rotation.
 * right now the script that calls this method is RotateRoadNew.
 *
 * Author: Jhonny
 * Date: 12/10/19
 * last update: -
 * By: -
 * Information updated: -
 */
public class RotatePivot : MonoBehaviour
{
    
    public float turnSpeed = 20f;


    /*
     * rotate left around sphereCenter, if rotation is in limit (max 30 in x axis).
     */
    public void MoveLeft(Vector3 rotation, Vector3 sphereCenter) {
        if (!((rotation.x > 30) && (rotation.x < 40))) {
            transform.RotateAround(sphereCenter, Vector3.right, turnSpeed * Time.deltaTime);
        }
    }

    /*
     * rotate right around sphereCenter, if rotation is in limit (min -30 in x axis).
     */
    public void MoveRight(Vector3 rotation, Vector3 sphereCenter) {
        if (!((rotation.x > 320) && (rotation.x < 330))) {
            transform.RotateAround(sphereCenter, Vector3.left, turnSpeed * Time.deltaTime);
        }
    }

    /*
     * rotate up around sphereCenter, if rotation is in limit (min -10 in z axis).
     */
    public void MoveUp(Vector3 rotation, Vector3 sphereCenter) {
        if (!((rotation.z > 335) && (rotation.z < 345))) {
            transform.RotateAround(sphereCenter, Vector3.back, turnSpeed * Time.deltaTime);
        }
    }

    /*
     * rotate down around sphereCenter, if rotation is in limit (max 10 in z axis).
     */
    public void MoveDown(Vector3 rotation, Vector3 sphereCenter) {
        if (!((rotation.z > 10) && (rotation.z < 20))) {
            transform.RotateAround(sphereCenter, Vector3.forward, turnSpeed * Time.deltaTime);
        }
    }
}
