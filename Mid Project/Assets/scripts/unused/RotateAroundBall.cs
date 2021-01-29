using UnityEngine;


/*
 * change object rotation around the attached SphereCollider.
 * IMPORTATNT - remember to set the variable (sphere) in the inspector window.
 *
 * Author: Yehonatan Sofri
 * Date: 12/10/19
 * last update: -
 * By: -
 * Information updated: -
 */
public class RotateAroundBall : MonoBehaviour
{
    public SphereCollider sphere;
    public Vector3 rotation;
    public Vector3 sphereCenter;
    public float turnSpeed = 20f;

    
    /*
     * As long as there's a connection between sphere and gameobject, input will apply.
     * it change rotation of object according to input.
     */
        void OnCollisionStay(Collision col)
    {
        rotation = transform.eulerAngles;

        if (col.collider == sphere)
        {
            sphereCenter = col.collider.attachedRigidbody.position;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                if (!((rotation.x > 30) && (rotation.x < 40)))
                {
                    transform.RotateAround(sphereCenter, Vector3.right, turnSpeed * Time.deltaTime);
                }
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                if (!((rotation.x > 320) && (rotation.x < 330)))
                {
                    transform.RotateAround(sphereCenter, Vector3.left, turnSpeed * Time.deltaTime);
                }
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (!((rotation.z > 340) && (rotation.z < 350)))
                {
                    transform.RotateAround(sphereCenter, Vector3.back, turnSpeed * Time.deltaTime);
                }
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (!((rotation.z > 10) && (rotation.z < 20)))
                {
                    transform.RotateAround(sphereCenter, Vector3.forward, turnSpeed * Time.deltaTime);
                }
            }
        }//end of first if
    }//end of OnCollisionStay()
}
