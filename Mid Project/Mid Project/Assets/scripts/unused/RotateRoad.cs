using UnityEngine;

/*
 * Script rotate the object according to the input (arrows on the keyboard).
 *
 * Author: Yehonatan Sofri
 * Date: 7/10/19 
 * last update: 10/10/19
 * By: Yam
 * Information updated: changed the buttons diractions to be more
 * intuitive (!for people like rotem).
 */
public class RotateRoad : MonoBehaviour
{


    public float   turnSpeed = 50f;
    public Vector3 rotation;        //current vector of rotation


    /*
     * Check wheter or not an arrow key is pressed.
     * The inner if check, check that current rotation doesn't cross limits.
     * Limits of rotation: +-30 degrees to x axis, +-10 degrees to z axis
     */
    void Update()
    {
        Vector3 rotation = transform.eulerAngles;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (!((rotation.z > 340) && (rotation.z < 350)))
            {
                transform.Rotate(Vector3.back, turnSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (!((rotation.z > 10) && (rotation.z < 20)))
            {
                transform.Rotate(Vector3.forward, turnSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (!((rotation.x > 30) && (rotation.x < 40)))
            {
                transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (!((rotation.x > 320) && (rotation.x < 330)))
            {
                transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime);
            }
        }
    }//end of Update()
}
