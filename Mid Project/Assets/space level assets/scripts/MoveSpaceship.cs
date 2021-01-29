using UnityEngine;


/*
 * Move the spaceship in space.
 *
 * Author: Jhonny
 * Date: 14/10/19
 * last update: -
 * By: -
 * Information updated: -
 */
public class MoveSpaceship : MonoBehaviour
{
    public Vector3 velocity;


    void Start()
    {
        velocity = new Vector3(1.2f, 0f, 1f);   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocity * Time.deltaTime);
    }
}