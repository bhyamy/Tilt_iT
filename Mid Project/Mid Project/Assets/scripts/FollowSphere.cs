using UnityEngine;
/*
 * Script controls the Main camera's position to always follow the sphere.
 * IMPORTATNT - remember to set the variable 'sphere' in the inspector window.
 * 
 * Author: Yehonatan Sofri
 * Date: 7/10/19
 * last update: 14/10/19
 * By: Yam
 * Information updated: offset is now changed
 */
public class FollowSphere : MonoBehaviour
{


     public GameObject sphere;      //sphere to follow
     


     /*
      * Set the offset variable - distance between camera and sphere
      */
     void Start() 
     {

     }

    /*
     * Update the position of the camera, depending on the sphere's position
     */
     void Update()
     {
         
     }
}
