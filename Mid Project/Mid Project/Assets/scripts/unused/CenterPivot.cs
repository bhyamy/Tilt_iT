using UnityEngine;

/*
 * Script keeps the road's pivot ("TZIR HASIVUV") centered along the sphere position.
 * this makes the rotation operation smooth and gentle.
 * IMPORTATNT - remember to set the variables (road, ball, cube) in the inspector window.
 *
 * Author: Yehonatan Sofri
 * Date: 7/10/19
 * last update: 12/10/19
 * By: Yehonatan Sofri
 * Information updated: Minimalizing code (cosmetic change)
 */
public class CenterPivot : MonoBehaviour
{
    
    public BoxCollider  road;      //the outer bounds of the cube, surface only
    public GameObject   sphere;   //sphere that rotates on road
    public GameObject   cube;     //the GameObject of the cube (road is part of it)
    public Vector3      temp;     //to save position of the cune
    public float        x;        //coordinate of vector


    /*
     * update position of pivot without moving the cube itself.
     * remember that the cube is chid of RoadPivot.
     */
    void Update()
    {  
        //get x coordinate of the sphere
        x = sphere.transform.position.x;
        temp = cube.gameObject.transform.position;

        //x & z coordinate are always the same (0 & 0)
        transform.position = new Vector3(x, transform.position.y, transform.position.z);

        //apply the saved position on the cube so it wouldn't move it's center
        cube.gameObject.transform.position = temp;
         
    }
}
